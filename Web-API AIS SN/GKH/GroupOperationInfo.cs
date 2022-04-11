using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;

namespace Web_API_AIS_SN.GKH
{
    public class GroupOperationInfo
    {
        public string Account { get; set; }
        public int? BaseId { get; set; }
        public long? GroupOperationId { get; set; }
        public string Uid { get; set; }

        public GroupOperationInfo(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            Account = @params.Where(q => q.Name == "account").FirstOrDefault()?.Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);
            var date = new DateTime();
            var bifdate = @params.Where(q => q.Name == "startDate").FirstOrDefault();
            DateTime.TryParse(bifdate == null ? null : bifdate.Value, out date);
            date = date == DateTime.MinValue ? new DateTime(1900, 1, 1) : date;
            var bufGroup = @params.Where(q => q.Name == "groupOperationId").FirstOrDefault();
            GroupOperationId = bufGroup == null ? (long?)null : Convert.ToInt64(bufGroup.Value);
        }

        public async Task<ResponseData> GetGroupOperationInfo()
        {
            var res = new ResponseData();
            try
            {
                if (GroupOperationId != null)
                {
                    if (BaseId == null)
                    {
                        res.Result.Code = 1;
                        res.Result.Message = String.Format("Не указан обязательный параметр № базы, требуется уточнение параметра");
                        return res;
                    }
                    var rows = new List<Dictionary<string, object>>();
                    var constring = new Helpers().GetConnectionString(BaseId.Value);
                    if (String.IsNullOrEmpty(constring))
                    {
                        res.Result.Code = 11;
                        res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                        return res;
                    }
                    using (var sn = new SNContext(constring))
                    {
                        string query = @$"SELECT * FROM CRM.""JnByGroupOperation""({Account},{GroupOperationId})";
                        var snOperation = await sn.Set<JnByGroupOperationResult>().FromSqlRaw(query).ToListAsync();
                        //var snOperation = sn.JnByGroupOperation(Account, (long)GroupOperationId).ToList();
                        var group = sn.GroupOperations.Where(z => z.Id == (long)GroupOperationId).SingleOrDefault();
#warning appsetting
                        //if (ConfigurationManager.AppSettings["onlyPaymentCalcfromPaymentOperation"] == "yes" && group != null)
                        if (group != null)
                        {
                            var fasetItem = sn.FasetItems.Where(z => z.Name == "Оплата" && z.FasetId == 42).SingleOrDefault();
                            if (group.TypeId == fasetItem.Id)
                            {
                                var calOperations = sn.CalcOperations.Where(
                                    z => z.Name == "Оплата реестром из БЦ" || z.Name == "Оплата бухгалтером" || z.Name == "Безналичная оплата" ||
                                    z.Name == "Безналичная оплата реестром из БЦ" || z.Name == "Оплата пени наличными" ||
                                    z.Name == "Оплата пени безналичными" || z.Name == "Оплата безналичными из 1С" || z.Name == "Оплата бухгалтером").Select(a => a.Id.ToString()).ToList();
                                snOperation = snOperation.Join(calOperations, z => z.CalcOperId, a => a, (z, a) => z).ToList();
                            }
                            //if(account== "70800015681") 
                            using (var smsr = new SMSRContext())
                            {
                                var availableProdiders = smsr.BaseSettings.Where(z => z.SettingName == "id поставщиков, услуги которых не отображать в API" && z.BaseId == BaseId).Select(z => z.Value).SingleOrDefault();
                                if (availableProdiders != null)
                                {
                                    var listprovidersString = availableProdiders.Split(',').ToList();
                                    var listproviders = new List<long>();
                                    foreach (var item in listprovidersString)
                                    {
                                        listproviders.Add(Convert.ToInt64(item));
                                    }

                                    snOperation.RemoveAll(s => listproviders.Contains(s.ProviderId.GetValueOrDefault()));
                                }
                            }
                        }
                        PropertyInfo[] Props = typeof(JnByGroupOperationResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                        //var snOperation = sn.JnByGroupOperation(account, (long)groupOperationId).ToList();
                        foreach (var item in snOperation)
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
                    if (rows.Any())
                    {
                        res.Result.Code = 0;
                        res.ResponseObject = rows;
                    }
                    else
                    {
                        res.Result.Code = 2;
                        res.Result.Message = "По указанному лицевому счету и номеру операции информация не найдена";
                    }
                }
                else
                {
                    res.Result.Code = 9;
                    res.Result.Message = "Не указан Номер операции";
                }
                return res;
            }
            catch (Exception ex)
            {

                res.Result.Code = 2;
                res.Result.Message = "ошибка обработки данных";
                return res;

            }
        }
    }
}
