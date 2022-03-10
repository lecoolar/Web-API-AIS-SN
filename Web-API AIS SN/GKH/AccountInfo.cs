using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;
using Web_API_AIS_SN.SMSR;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.GKH
{
    public class AccountInfo
    {
        public string Account { get; set; }
        public string Uid { get; set; }

        public int? BaseId { get; set; }

        public AccountInfo(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            //Request tmp = JsonConvert.DeserializeObject<Request>(param);
            Account = @params.Where(q => q.Name == "account").FirstOrDefault().Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);
        }
        public string GetAccountInfo()
        { 
            var webService = new List<WebService>();
            var constring = "";
            var resultJson = "";
            var res = new ResponseData();
            var userPermisson = false;
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            if (BaseId == null || BaseId == 0)
            {
                res.Result.Code = 1;
                res.Result.Message = String.Format("Не указан обязательный параметр №базы, требуется уточнение параметра");
                return new Helpers().ToJson(res);
            }
            else
            {
                constring = new Helpers().GetConnectionString(BaseId.Value);
            }

            if (String.IsNullOrEmpty(constring))
            {
                res.Result.Code = 11;
                res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                return new Helpers().ToJson(res);
            }
            else
            {
                using (var sn = new SNContext(constring))
                {
                    var accountId = sn.Accounts.FirstOrDefault(a => a.Number == Account)?.Id ?? 0;
                    userPermisson = new Helpers().CheckUserPermisson(constring, accountId);
                    if (userPermisson)
                    {
                        AccountInfoResult accountInfoList = new AccountInfoResult(Account,sn);
                        //PropertyInfo[] Props = typeof(AccountInfoResult).GetProperties();
                        PropertyInfo[] Props = accountInfoList.GetType().GetProperties();

                            var row = new Dictionary<string, object>();
                            foreach (var prop in Props)
                            {
                                row.Add(prop.Name, prop.GetValue(accountInfoList, null));
                                //inserting property values to datatable rows
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
                    if (!userPermisson)
                {
                    res.Result.Code = 15;
                    res.Result.Message = "Пользователь не найден, либо нет прав на просмотр.";
                }
                else
                {
                    res.Result.Code = 2;
                    res.Result.Message = "По указанному лицевому счету информация об услугах не найдена";
                }
            }
            //resultJson = serializer.Serialize(res);
            resultJson = JsonConvert.SerializeObject(res);
            return resultJson;
        }

    }
}
