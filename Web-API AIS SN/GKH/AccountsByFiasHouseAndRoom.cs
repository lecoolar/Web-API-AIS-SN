using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SMSR;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.GKH
{
    public class WebAccounts
    {
        public List<string> Accounts { get; set; }
        public WebService Web { get; set; }
    }

    public class AccountsByFiasHouseAndRoom
    {
        private string Phone { get; set; }
        public string FiasHouse { get; set; }
        public string Room { get; set; }
        public string Uid { get; set; }

        public AccountsByFiasHouseAndRoom(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            FiasHouse = @params.Where(q => q.Name == "fiasHouse").FirstOrDefault().Value;
            Room = @params.Where(q => q.Name == "room").FirstOrDefault().Value;
        }

        public string GetAccountsByFiasHouseAndRoom()
        {
            var resultJson = "";
            var res = new ResponseData();

            using (var smsr = new SMSRContext())
            {
                var responseObject = smsr.AccountsInfoViews.Where(f => f.FiasCode == FiasHouse && f.Flat == Room).ToList();
                if (String.IsNullOrEmpty(Room) && !responseObject.Any())
                {
                    responseObject = smsr.AccountsInfoViews.Where(f => f.FiasCode == FiasHouse).ToList();
                }
                if (!responseObject.Any())
                {
                    res.Result.Code = 2;
                    res.Result.Message = "Информация по адресу не найдена";
                }
                else
                {
                    var webAndacc = responseObject.Select(q => new { q.BaseId, q.Accountnumber, q.Area, q.BaseName }).Distinct().ToList();
                    var rows = new List<Dictionary<string, object>>();
                    var ListAccounts = webAndacc.Select(q => q.Accountnumber).ToList();
                    var ws = webAndacc.Select(q => new { q.BaseId, q.BaseName, q.Area }).Distinct().FirstOrDefault();
                    var constring = new Helpers().GetConnectionString(ws.BaseId);
                    using (var sn = new SNContext(constring))
                    {
                        AccountSearchByNumberResult accountInfoList = new AccountSearchByNumberResult(Account, sn);
                        PropertyInfo[] Props = typeof(AccountSearchByNumberResult).GetType().GetProperties();
                        foreach (var acc in ListAccounts)
                        {
                            var accountSearch = sn.AccountSearchByNumber(acc, false, false, "SN").OrderByDescending(a => a.isClose).ToList();
                            foreach (var search in accountSearch)
                            {
                                var row = new Dictionary<string, object>();
                                for (int i = 0; i < Props.Length; i++)
                                {
                                    //inserting property values to datatable rows
                                    row.Add(Props[i].Name, Props[i].GetValue(search, null));
                                }
                                row.Add("numberBase", ws.baseId);
                                row.Add("baseName", ws.baseName);
                                row.Add("orgName", ws.area);
                                row.Add("baseId", ws.baseId);
                                rows.Add(row);
                            }
                        }
                    }
                    res.responseObject = rows;
                }
            }

                return resultJson;
        }

    }
}
