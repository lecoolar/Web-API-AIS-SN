using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SMSR;

namespace Web_API_AIS_SN.GKH
{
    public class Consumption
    {
        public string Account { get; set; }
        public string Uid { get; set; }
        public string SystemName { get; set; }
        public int? BaseId { get; set; }
        public DateTime Period { get; set; }

        public Consumption(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            Account = @params.Where(q => q.Name == "account").FirstOrDefault().Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);
            var date = new DateTime();
            var bifdate = @params.Where(q => q.Name == "period").FirstOrDefault();
            DateTime.TryParse(bifdate == null ? null : bifdate.Value, out date);
            Period = date;
        }

        public async Task<ResponseData> GetConsumption()
        {
            var webservice = new WebService();
            var res = new ResponseData();
            var rows = new List<Dictionary<string, object>>();
            var availableProdiders = "";
            bool useOnlyAvailableHouseId = false;

            using (var smsr = new SMSRContext())
            {
                availableProdiders = smsr.BaseSettings.SingleOrDefault(z => z.SettingName == "id поставщиков, услуги которых отображать в API" && z.BaseId == BaseId)?.Value;
                useOnlyAvailableHouseId = smsr.Settings.SingleOrDefault(s => s.Name == "useOnlyAvailableHouseId")?.Value == "yes" ? true : false;
            }
            if (BaseId == null)
            {
                res.Result.Code = 1;
                res.Result.Message = String.Format("Не указан обязательный параметр № базы, требуется уточнение параметра");
                return res;
            }

            var constring = new Helpers().GetConnectionString(BaseId.Value);
            if (String.IsNullOrEmpty(constring))
            {
                res.Result.Code = 11;
                res.Result.Message = $"Ошибка, не удалось собрать строку подключения к базе!";
                return res;
            }

            var periodSetting = new SettingSN(constring).GetValueByGroupNameAndName("Интерфейсы", "Выдача информации по открытому периоду")?.Value ?? "да";
            var calPeriod = new CalcPeriodSN(constring).GetCurrent().FromDate;
            if (periodSetting.ToLower() == "нет")
            {
                if (Period >= calPeriod)
                {
                    res.Result.Code = -3;
                    res.Result.Message = String.Format("Ошибка, по данному периоду производится расчёт!");
                    return res;
                }
            }

            Period = Period == DateTime.MinValue ? DateTime.Today : Period;


            DateTime fdate = new DateTime(Period.Year, Period.Month, 1);
            DateTime tdate = new DateTime(Period.Year, Period.Month, 1).AddMonths(1).AddDays(-1);

            using (var sn = new SNContext(constring))
            {
                if (useOnlyAvailableHouseId)
                {
                    var houseId = new AccountSN(constring).GetHouseIdByAccount(Account);
                    var group = sn.Groups.FirstOrDefault(g => g.Name == "AvailableHouseId");

                    if (group != null)
                    {
                        List<string> availableHouseList = sn.Elements.Where(e => e.IdGroup == group.Id)
                            .Select(i => i.IdObject.ToString()).ToList();

                        if (!availableHouseList.Contains(houseId))
                        {
                            res.Result.Code = 1;
                            res.Result.Message = "Дом не входит в список разрешенных";
                            return res;
                        }
                    }
                }

                PropertyInfo[] Props = typeof(AccountConsumptionResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                //try
                //{
                var acc = sn.Accounts.Where(a => a.Number == Account).FirstOrDefault();
                long? calcId = null;
#warning appsetting
                //SystemName = String.IsNullOrEmpty(SystemName) ? new PublicMetods().getAppSetting("systemName") : SystemName;
                SystemName = String.IsNullOrEmpty(SystemName) ? "LK" : SystemName;
                if (SystemName == "LK")
                {
                    var sdate = fdate.ToString("yyyyMMdd");
                    var edate = tdate.ToString("yyyyMMdd");
                    SqlParameter sqlaccountId = new SqlParameter("@accountId", acc.Id);
                    SqlParameter sqlSdate = new SqlParameter("@fromDateString", sdate);
                    SqlParameter sqlEdate = new SqlParameter("@toDateString", edate);
                    SqlParameter sqlCalcId = new SqlParameter()
                    {
                        ParameterName = "@calcloId",
                        SqlDbType = SqlDbType.BigInt,
                        Direction = ParameterDirection.Output,
                    };

                    string Account_RecalcForLk = @$"EXEC [sn].[Account_RecalcForLk] @accountId, @fromDateString ,@toDateString, @calcloId OUTPUT ";
                    var qwe = await sn.Set<Account_RecalcResult>().FromSqlRaw(Account_RecalcForLk, sqlaccountId, sqlSdate, sqlEdate, sqlCalcId).ToListAsync();
                    calcId = (long)sqlCalcId.Value;
                }
                else
                {
                    SqlParameter sqlaccountId = new SqlParameter("@accountId", acc.Id);
                    SqlParameter sqlSdate = new SqlParameter("@fromDateString", fdate);
                    SqlParameter sqlEdate = new SqlParameter("@toDateString", tdate);
                    SqlParameter sqlCalcId = new SqlParameter()
                    {
                        ParameterName = "@calcloId",
                        SqlDbType = SqlDbType.BigInt,
                        Direction = ParameterDirection.Output,
                    };
                    
                    string Account_Recalc = @$"EXEC [sn].[Account_Recalc] @accountId, @fromDateString ,@toDateString, @calcloId OUTPUT ";
                    var qwe = await sn.Set<Account_RecalcResult>().FromSqlRaw(Account_Recalc).FirstOrDefaultAsync();
                    //sn.Account_Recalc(acc.Id, fdate, tdate, ref calcId);
                }
                string query = @$"SELECT * FROM CRM.""AccountConsumption""({calcId},'{fdate}')";
                var consumption = await sn.Set<AccountConsumptionResult>().FromSqlRaw(query).ToListAsync();

                if (availableProdiders != null)
                {
                    var listprovidersString = availableProdiders.Split(',').ToList();
                    var listproviders = new List<long>();
                    foreach (var item in listprovidersString)
                    {
                        listproviders.Add(Convert.ToInt64(item));
                    }
                    consumption = consumption.Join(listproviders, c => c.ProviderId, l => l, (c, l) => c).ToList();
                }
                foreach (var item in consumption)
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows
                        row.Add(Props[i].Name, Props[i].GetValue(item, null));
                    }
                    rows.Add(row);
                }
                //}
                //catch (Exception ex)
                //{
                //    res.Result.Code = -1;
                //    res.Result.Message = "Ошибка. В данный момент расчёт произвести нельзя";
                //    res.ResponseObject = new List<Dictionary<string, object>>();

                //}
            }
            if (rows.Any())
            {
                res.Result.Code = 0;
                res.ResponseObject = rows;
            }
            else
            {
                res.Result.Code = 2;
                res.Result.Message = "Нет данных";
            }
            res.ResponseObject = rows;
            return res;
        }
    }
}
