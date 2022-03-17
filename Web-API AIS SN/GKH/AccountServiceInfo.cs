using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SMSR;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.GKH
{
    public class AccountServiceInfo
    {
        public string Account { get; set; }
        public string Uid { get; set; }
        public int? BaseId { get; set; }

        public AccountServiceInfo(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            Account = @params.Where(q => q.Name == "account").FirstOrDefault().Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);
        }

        public async Task<ResponseData> GetAccountServiceInfo()
        {
            var constring = "";
            var webservice = new WebService();
            var res = new ResponseData();
            string availableProdiders = String.Empty;
            bool showBankrupt = true;
            bool useOnlyAvailableHouseId = false;


            using (var smsr = new SMSRContext())
            {
#warning выводит все значения
                if ("LK" != "CRM")
                availableProdiders = smsr.BaseSettings.SingleOrDefault(z => z.SettingName == "id поставщиков, услуги которых не отображать в API" && z.BaseId == BaseId)?.Value;
                showBankrupt = smsr.Settings.SingleOrDefault(s => s.Name == "showBankrupt")?.Value == "no" ? false : true;
                useOnlyAvailableHouseId = smsr.Settings.SingleOrDefault(s => s.Name == "useOnlyAvailableHouseId")?.Value == "yes" ? true : false;
            }
            if (BaseId == null || BaseId == 0)
            {
                res.Result.Code = 1;
                res.Result.Message = String.Format("Не указан обязательный параметр №_базы, требуется уточнение параметра");
                return res;
            }
            else
            {
                constring = new Helpers().GetConnectionString(BaseId.Value);
            }
            //var accountServiceInfo = new DataTable();
            //var settingsInput = new DataTable();

            if (String.IsNullOrEmpty(constring))
            {
                res.Result.Code = 11;
                res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                return res;
            }
            var rows = new List<Dictionary<string, object>>();
            using (var sn = new SNContext(constring))
            {
                var accountId = sn.Accounts.FirstOrDefault(a => a.Number == Account)?.Id ?? 0;
                var userPermisson = new Helpers().CheckUserPermisson(constring, accountId);
                if (userPermisson)
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

                    var resu = new List<AccountServicesInfoResult>();
                    string query = @$"SELECT * FROM CRM.""GetUser""()";
                    GetUserResult user = await sn.Set<GetUserResult>().FromSqlRaw(query).FirstOrDefaultAsync();
                    var userId = user.Id;
                    var accountServices = sn.UserAccountServices.Where(u => u.UserId == userId && u.AccountId == accountId).Select(u => u.AccountServiceId).ToList();
                    var fullPermisson = sn.UserUpdates.FirstOrDefault(u => u.UserId == userId)?.FullPermisson ?? false;
                    query = @$"SELECT * FROM CRM.""AccountServicesInfo""({Account})";
                    if (fullPermisson)
                    {
                        if (showBankrupt)
                            resu = await sn.Set<AccountServicesInfoResult>().FromSqlRaw(query).ToListAsync();
                        else
                            resu = await sn.Set<AccountServicesInfoResult>().FromSqlRaw(query).Where(a => a.IsBankrupt != true).ToListAsync();
                    }
                    else
                    {
                        if (showBankrupt)
                            resu = await sn.Set<AccountServicesInfoResult>().FromSqlRaw(query).Where(s => accountServices.Contains(s.Id.Value)).ToListAsync();
                        else
                            resu = await sn.Set<AccountServicesInfoResult>().FromSqlRaw(query).Where(s => accountServices.Contains(s.Id.Value) && s.IsBankrupt != true).ToListAsync();
                    }

                    if (!String.IsNullOrEmpty(availableProdiders))
                    {
                        var listprovidersString = availableProdiders.Split(',').ToList();
                        var listproviders = new List<long>();
                        foreach (var item in listprovidersString)
                        {
                            listproviders.Add(Convert.ToInt64(item));

                        }

                        resu.RemoveAll(r => listproviders.Contains(r.ProviderId.GetValueOrDefault()));
                    }

                    //DataTable dt = new DataTable();
                    PropertyInfo[] Props = typeof(AccountServicesInfoResult).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    foreach (var item in resu)
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < Props.Length; i++)
                        {
                            row.Add(Props[i].Name, Props[i].GetValue(item, null));
                        }
                        rows.Add(row);
                    }
                    //log.LogAdd($" Result AccoutServiceInfo: account {account} - ResultRowsCount {resu.Count()}");

                    if (rows.Any())
                    {
                        res.Result.Code = 0;
                        res.ResponseObject = rows;
                    }
                    else
                    {
                        res.Result.Code = 2;
                        res.Result.Message = "По указанному лицевому: " + Account + " информация об услугах не найдена";
                    }
                }
                else
                {
                    res.Result.Code = 15;
                    res.Result.Message = "Пользователь не найден, либо нет прав на просмотр.";
                }
            }
            return res;
        }
    }
}
