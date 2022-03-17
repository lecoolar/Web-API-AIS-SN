using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SMSR;

namespace Web_API_AIS_SN.GKH
{
    public class AccountCounters
    {
        public string Account { get; set; }
        public int? BaseId { get; set; }
        public bool NeedCommunal { get; set; }
        public string Uid { get; set; }
        public string SystemName { get; set; }

        public AccountCounters(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            Account = @params.FirstOrDefault(q => q.Name == "account").Value;
            var bId = @params.FirstOrDefault(q => q.Name == "baseId")?.Value;
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId);
            var bneedCommunal = @params.FirstOrDefault(q => q.Name == "needCommunal")?.Value;
            NeedCommunal = bneedCommunal == null ? false : Convert.ToBoolean(bneedCommunal);
            SystemName = @params.FirstOrDefault(q => q.Name == "systemName")?.Value;
        }
        public async Task<AccountResponseData> GetAccountCounters()
        {
            var constring = "";

            var resultJson = "";
            var pb = new PublicMetods();
            var webservice = new List<WebService>();
            var res = new AccountResponseData();
            if (BaseId == null || BaseId == 0)
            {
                res.Result.Code = 1;
                res.Result.Message = String.Format("Не указан обязательный параметр № базы, требуется уточнение параметра");
                return res;
            }
            else
            {
                constring = new Helpers().GetConnectionString(BaseId.Value);
            }
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            if (String.IsNullOrEmpty(constring))
            {
                res.Result.Code = 11;
                res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                return res;
            }
            res =await pb.GetAccountCounters(constring, Account, BaseId ?? 0, NeedCommunal, SystemName, true, true, true);
            return res;
        }
    }
}
