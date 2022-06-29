using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.GKH;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;

namespace Web_API_AIS_SN.LK
{
    public class BilledAmounts
    {
        public string Uid { get; set; }
        public string Account { get; set; }
        public int? BaseId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public class ReturnClass
        {
            public string Period { get; set; }
            public decimal Summ { get; set; }
        }

        public BilledAmounts(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            //metodRequest = tmp.metodRequest;
            Account = @params.Where(q => q.Name == "account").FirstOrDefault().Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);

            var date = new DateTime();
            var bifdate = @params.Where(q => q.Name == "fromDate").FirstOrDefault();
            DateTime.TryParse(bifdate == null ? null : bifdate.Value, out date);
            FromDate = date;
            bifdate = @params.Where(q => q.Name == "toDate").FirstOrDefault();
            DateTime.TryParse(bifdate == null ? null : bifdate.Value, out date);
            ToDate = date;
        }

        public async Task<ResponseData> GetBilledAmounts()
        {
            var constring = "";
            var resultJson = "";
            var res = new ResponseData();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            using (var smsr = new SMSRContext())
            {
                if (BaseId == null)
                {
                    res.Result.Code = 1;
                    res.Result.Message = String.Format("Не указан обязательный параметр № базы, требуется уточнение параметра");
                    return res;
                }
                constring = new Helpers().GetConnectionStringByWS(smsr.WebServices.Where(z => z.Id == BaseId).FirstOrDefault());

                var calcPeriod = new CalcPeriodSN(constring).GetCurrent();
                using (var sn = new SNContext(constring))
                {
                    var rep = new SeletReportsAndSettingResult();
                    string query = @$"SELECT * FROM CRM.""SeletReportsAndSetting""()";
                    var reps = await sn.Set<SeletReportsAndSettingResult>().FromSqlRaw(query).ToListAsync();
                    // var reps = sn.SeletReportsAndSetting().ToList();
                    if (reps.Count > 1)
                    {
                        rep = reps.FirstOrDefault(z => z.ReportName.ToLower() == "новый платежный документ" && z.SettingName.ToLower() == "по умолчанию");
                    }
                    if (reps.Count == 1)
                    {
                        rep = reps.FirstOrDefault();
                    }



                    if (FromDate == null || FromDate == DateTime.MinValue)
                    {
                        FromDate = calcPeriod.FromDate.AddMonths(-1);
                    }

                    if (ToDate == null || ToDate == DateTime.MinValue)
                    {
                        ToDate = calcPeriod.FromDate;
                    }

                    if (FromDate >= calcPeriod.FromDate)
                    {
                        FromDate = calcPeriod.FromDate.AddMonths(-1);
                    }
                    if (ToDate >= calcPeriod.FromDate)
                    {
                        ToDate = calcPeriod.ToDate.AddMonths(-1);
                    }
                    FromDate = new DateTime(FromDate.Year, FromDate.Month, 1);
                    ToDate = new DateTime(ToDate.Year, ToDate.Month, DateTime.DaysInMonth(ToDate.Year, ToDate.Month));
                    PropertyInfo[] Props = typeof(ReturnClass).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    var result = new List<ReturnClass>();
                    string getBilledAmounts = @$"SELECT * FROM CRM.""GetBilledAmounts""({Account},'{FromDate}','{ToDate}',{rep.SettingId})";
                    var billedAmounts = await sn.Set<GetBilledAmountsResult>().FromSqlRaw(getBilledAmounts).ToListAsync();
                    //var billedAmounts = sn.GetBilledAmounts(account, fromDate, toDate, rep.settingId).ToList();


                    if (billedAmounts.Any())
                    {
                        result = billedAmounts.Select(a => new ReturnClass { Period = a.Period, Summ = a.MaxSummAndPeni ?? 0 }).ToList();
                    }
                    else
                    {
                        var accountsn = new AccountSN(constring).GetByNumber(Account);
                        if (accountsn == null)
                        {
                            res.Result.Code = 2;
                            res.Result.Message = "Лицевой счет не найден в системе";
                            res.Result.Message = null;
                            res.Result.Code = 0;
                            res.ResponseObject.Add(new Dictionary<string, object>() {
                    {      "period", "2020-03-01 00:00:00.000" },
                    { "summ", 950.97 }
                });
                            return res;
                        }
                        if (accountsn.Dateb >= DateTime.Today.AddMonths(-3))
                        {

                            var qwe = new AccountSN(constring).GetByApartmentIdWithCloced(accountsn.ApartmentId);
                            accountsn = qwe.Where(z => z.Datee >= DateTime.Today.AddMonths(-3)).SingleOrDefault();
                        }
                        if (accountsn != null)
                        {
                            getBilledAmounts = @$"SELECT * FROM CRM.""GetBilledAmounts""({accountsn.Number},'{FromDate}','{ToDate}',{rep.SettingId})";
                            billedAmounts = await sn.Set<GetBilledAmountsResult>().FromSqlRaw(getBilledAmounts).ToListAsync();
                            //billedAmounts = sn.GetBilledAmounts(accountsn.number, fromDate, toDate, rep.settingId).ToList();
                        }
                        result = billedAmounts.Select(a => new ReturnClass { Period = a.Period, Summ = a.MaxSummAndPeni ?? 0 }).ToList();
                    }
                    var listdate = new List<string>();
                    listdate = result.Select(z => z.Period).Distinct().ToList();



                    foreach (var date in listdate)
                    {

                        if (result.Where(z => z.Period == date).Count() > 1)
                        {

                            result.Remove(result.Where(z => z.Period == date).First());
                        }
                    }

                    foreach (var item in result)
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < Props.Length; i++)
                        {
                            //inserting property values to datatable rows
                            row.Add(Props[i].Name, Props[i].GetValue(item, null));
                        }
                        rows.Add(row);
                    }
                }
                if (!rows.Any())
                {
                    res.Result.Message = "По указанному лицевому счету информация не найдена";                   
                }
                res.ResponseObject = rows;           
                return res;

            }
        }
    }
}

