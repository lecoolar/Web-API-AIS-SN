using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.GKH
{
    public class OperationJournal
    {
        public string Account { get; set; }
        public int? BaseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Uid { get; set; }
        public string OperationType { get; set; }
        public int? TypeId { get; set; }

        public OperationJournal(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            Account = @params.Where(q => q.Name == "account").FirstOrDefault().Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);
            var date = new DateTime();
            var bifdate = @params.Where(q => q.Name == "startDate").FirstOrDefault();
            DateTime.TryParse(bifdate == null ? null : bifdate.Value, out date);
            date = date == DateTime.MinValue ? new DateTime(1900, 1, 1) : date;
            StartDate = date;
            bifdate = @params.Where(q => q.Name == "endDate").FirstOrDefault();
            DateTime.TryParse(bifdate == null ? null : bifdate.Value, out date);
            date = date == DateTime.MinValue ? DateTime.Now : date.AddDays(1).AddMinutes(-1);
            EndDate = date;
            var tId = @params.Where(q => q.Name == "typeId").FirstOrDefault();
            TypeId = tId == null ? (int?)null : Convert.ToInt32(tId.Value);
            var operationTypeBuf = @params.Where(q => q.Name == "operationType").FirstOrDefault();
            OperationType = operationTypeBuf == null ? null : operationTypeBuf.Value;
        }

        public async Task<ResponseData> GetOperationJournal()
        {
            var res = new ResponseData();
            bool showBankrupt = true;
            bool useOnlyAvailableHouseId = false;
            long accId;

            using (var smsr = new SMSRContext())
            {
                showBankrupt = smsr.Settings.SingleOrDefault(s => s.Name == "showBankrupt")?.Value == "no" ? false : true;
                useOnlyAvailableHouseId = smsr.Settings.SingleOrDefault(s => s.Name == "useOnlyAvailableHouseId")?.Value == "yes" ? true : false;

                if (BaseId == null)
                {
                    res.Result.Code = 1;
                    res.Result.Message = String.Format("Не указан обязательный параметр № базы, требуется уточнение параметра");
                    return res;
                }
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                var constring = new Helpers().GetConnectionString(BaseId.Value);
                if (String.IsNullOrEmpty(constring))
                {
                    res.Result.Code = 11;
                    res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                    return res;
                }

                var periodSetting = new SettingSN(constring).GetValueByGroupNameAndName("Интерфейсы", "Выдача информации по открытому периоду")?.Value ?? "да";
                var calPeriod = new CalcPeriodSN(constring).GetCurrent().FromDate;
                if (periodSetting.ToLower() == "нет" && OperationType != "Payment")
                {
                    EndDate = EndDate >= calPeriod ? EndDate.AddMonths(-1) : EndDate;
                    if (StartDate >= calPeriod)
                    {
                        res.Result.Code = -3;
                        res.Result.Message = String.Format("Ошибка, по данному периоду производится расчёт!");
                        return res;
                    }
                }

                using (var sn = new SNContext(constring))
                {
                    if (String.IsNullOrEmpty(Account))
                    {
                        res.Result.Code = -1;
                        res.Result.Message = "Параметр account не задан";
                        return res;
                    }
                    else
                    {
                        var acc = sn.Accounts.FirstOrDefault(a => a.Number == Account);
                        if (acc != null)
                        {
                            accId = acc.Id;
                        }
                        else
                        {
                            res.Result.Code = -1;
                            res.Result.Message = $"Не найден пользователь с ЛС {Account}";
                            return res;
                        }
                    }

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

                    PropertyInfo[] Props = typeof(GroupOperationJournal_BankruptResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                    var snOperation = new List<GroupOperationJournal_BankruptResult>();
                    var fasetItem = new FasetItem();

                    switch (OperationType)
                    {
                        case "Payment":
                            fasetItem = sn.FasetItems.SingleOrDefault(z => z.Name == "Оплата" && z.FasetId == 42);
                            string query = @$"SELECT * FROM CRM.""GroupOperationJournal_Bankrupt""({accId},{fasetItem.Id},'{StartDate}','{EndDate.AddDays(1)}',{(showBankrupt?1:0)})";
                            snOperation = await sn.Set<GroupOperationJournal_BankruptResult>().FromSqlRaw(query).ToListAsync();
                            break;
                        case "Accrual":
                            fasetItem = sn.FasetItems.SingleOrDefault(z => z.Name == "Начисление" && z.FasetId == 42);
                            string query1 = @$"SELECT * FROM CRM.""GroupOperationJournal_Bankrupt""({accId},{fasetItem.Id},'{StartDate}','{EndDate.AddDays(1)}',{(showBankrupt ? 1 : 0)})";
                            snOperation = await sn.Set<GroupOperationJournal_BankruptResult>().FromSqlRaw(query1).ToListAsync();
                            break;
                        case "Indication":
                            fasetItem = sn.FasetItems.SingleOrDefault(z => z.Name == "Начисление" && z.FasetId == 42);

                            var subFasetItem = sn.FasetItems.SingleOrDefault(z => z.Name == "Доначисление по контрольным показаниям счетчика" && z.FasetId == 24);
                            string query2 = @$"SELECT * FROM CRM.""GroupOperationJournal_Bankrupt""({accId},{fasetItem.Id},'{StartDate}','{EndDate.AddDays(1)}',{(showBankrupt ? 1 : 0)})";
                            snOperation = await sn.Set<GroupOperationJournal_BankruptResult>().FromSqlRaw(query2)
                                .Where(z => z.SubTypeId == subFasetItem.Id)
                                .ToListAsync();
                            break;
                        default:
                            string query3 = @$"SELECT * FROM CRM.""GroupOperationJournal_Bankrupt""({accId},{fasetItem.Id},'{StartDate}','{EndDate.AddDays(1)}',{(showBankrupt ? 1 : 0)})";
                            snOperation =await sn.Set<GroupOperationJournal_BankruptResult>().FromSqlRaw(query3).ToListAsync();
                            break;
                    }

                    //snOperation = snOperation.Where(z => z.id == 356198).ToList();
                    var availableProdiders = smsr.BaseSettings.Where(z => z.SettingName == "id поставщиков, услуги которых не отображать в API" && z.BaseId == BaseId).Select(z => z.Value).SingleOrDefault();
                    if (availableProdiders != null)
                    {
                        var listprovidersString = availableProdiders.Split(',').ToList();
                        var listproviders = new List<long>();
                        foreach (var item in listprovidersString)
                        {
                            listproviders.Add(Convert.ToInt64(item));

                        }
#warning appsetting
                        //if (ConfigurationManager.AppSettings["onlyPaymentCalcfromPaymentOperation"] == "yes" || Account == "70800015681")
                        if (Account == "70800015681")
                        {

                            for (int i = 0; i < snOperation.Count(); i++)
                            {
                                var oper = snOperation[i];

                                string query = @$"SELECT * FROM CRM.""GetProvidersIdInvolvedInOperation""({oper.Id},{Account})";
                                var providersList =await sn.Set<GetProvidersIdInvolvedInOperationResult>().FromSqlRaw(query).ToListAsync();
                                var providersId = providersList.Select(z => (long)z.ProviderId).Distinct().ToList();
                                if (providersId.Any())
                                {
                                    var qwe = providersId.Except(listproviders);
                                    if (!qwe.Any())
                                    {
                                        snOperation.RemoveAt(i); i--;
                                    }
                                }
                                string query1 = @$"SELECT * FROM CRM.""JnByGroupOperation""({Account},{oper.Id})";
                                var JnOperation =await sn.Set<JnByGroupOperationResult>().FromSqlRaw(query1).ToListAsync();
                                var onlyShow = JnOperation.Join(listproviders, z => z.ProviderId, a => a, (z, a) => z).ToList();
                                //snOperation = onlyShow;
                                //var notShow = JnOperation.Except(onlyShow).ToList();

                                //if (notShow.Any())
                                //{
                                //    var paySumm = onlyShow.Sum(z => Convert.ToDecimal(z.summ));
                                //    snOperation[i].summ= (paySumm *(-1)).ToString();
                                //    snOperation[i].paymentSumm = paySumm.ToString();
                                //}

                                //if (oper.id == 304169 || oper.id == 356198)
                                //{
                                //    snOperation[i].paymentAgentId = 115;
                                //    snOperation[i].paymentAgentName = "ГУП \"ТЭК СПб\"";
                                //}
                            }
                        }
                        else
                        {
                            for (int i = 0; i < snOperation.Count(); i++)
                            {
                                var oper = snOperation[i];
                                string query = @$"SELECT * FROM CRM.""GetProvidersIdInvolvedInOperation""({oper.Id},{Account})";
                                var providersList =await sn.Set<GetProvidersIdInvolvedInOperationResult>().FromSqlRaw(query).ToListAsync();
                                var providersId = providersList.Select(z => (long)z.ProviderId).Distinct().ToList();
                                if (providersId.Any())
                                {
                                    var qwe = providersId.Except(listproviders).ToList();
                                    if (qwe.Any())
                                    {
                                        snOperation.RemoveAt(i); i--;
                                    }
                                }
                            }
                        }
                    }


                    foreach (var item in snOperation)
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < Props.Length; i++)
                        {
                            row.Add(Props[i].Name, Props[i].GetValue(item, null));
                        }
                        rows.Add(row);
                    }
                }
                if (!rows.Any())
                {
                    res.Result.Code = 2;
                    res.Result.Message = "По указанному лицевому счету информация не найдена";
                }
                res.ResponseObject = rows;
                return res;
            }
        }
        public class ResponseJournal
        {
            public BaseResult Result { get; set; }
            public List<GroupOperation> ResponseObject { get; set; }
            public ResponseJournal()
            {
                Result = new BaseResult();
                ResponseObject = new List<GroupOperation>();
            }

        }
    }
}
