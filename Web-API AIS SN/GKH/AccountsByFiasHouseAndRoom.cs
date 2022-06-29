using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;
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
        public string FiasHouse { get; set; }
        public string Room { get; set; }
        public string Uid { get; set; }

        public AccountsByFiasHouseAndRoom(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            FiasHouse = @params.Where(q => q.Name == "fiasHouse").FirstOrDefault().Value;
            Room = @params.Where(q => q.Name == "room").FirstOrDefault().Value;
        }

        public async Task<ResponseData> GetAccountsByFiasHouseAndRoom()
        {
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
                        foreach (var acc in ListAccounts)
                        {
                            string query = @$"SELECT * FROM CRM.""AccountSearchByNumber""({acc},{0},{0},'SN')";
                            var accountSearch =await sn.Set<AccountSearchByNumberResult>().FromSqlRaw(query).OrderByDescending(a => a.IsClose).FirstOrDefaultAsync();
                            PropertyInfo[] Props = accountSearch.GetType().GetProperties();

                            var row = new Dictionary<string, object>();
                            for (int i = 0; i < Props.Length; i++)
                            {
                                //inserting property values to datatable rows
                                row.Add(Props[i].Name, Props[i].GetValue(accountSearch, null));
                            }
                            row.Add("numberBase", ws.BaseId);
                            row.Add("baseName", ws.BaseName);
                            row.Add("orgName", ws.Area);
                            rows.Add(row);
                        }
                    }
                    res.ResponseObject = rows;
                }
            }
            return res;
        }

    }
}


