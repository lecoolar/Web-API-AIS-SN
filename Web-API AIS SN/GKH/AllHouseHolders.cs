using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SMSR;

namespace Web_API_AIS_SN.GKH
{
    public class AllHouseHolders
    {
        public string Uid { get; set; }

        public AllHouseHolders(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
        }
        public async Task<ResponseData> GetAllHouseHolders()
        {
            var res = new ResponseData();
            var rows = new List<Dictionary<string, object>>();
            try
            {
                var ws = new List<WebService>();
                using (var lk = new SMSRContext())
                {
                    ws = lk.WebServices
                        .Where(w => w.IsLkactive.Value && w.Area != null && w.SystemType == "AIS_GKH")
                        .ToList();
                }
                string constring;
                if (!ws.Any())
                {
                    res.Result.Code = 11;
                    res.Result.Message = "Не удалось получить строки подключения.";
                    return res;
                }

                foreach (var item in ws)
                {
                    constring = new Helpers().GetConnectionStringByWS(item);

                    if (String.IsNullOrEmpty(constring))
                    {
                    }
                    else
                    {
                        var houseHolders = new OrganizationSN(constring).GetAllHouseHolders();
                        foreach (var hh in houseHolders)
                        {
                            var row = new Dictionary<string, object>();
                            row.Add("orgId", hh.Id);
                            row.Add("organizationName", hh.ShortName);
                            row.Add("organizationINN", hh.Inn);
                            row.Add("organizationOGRN", hh.Ogrn);
                            row.Add("organizationKPP", hh.Kpp);
                            row.Add("organizationCode", hh.Code);
                            row.Add("baseId", item.Id);
                            rows.Add(row);
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                res.Result.Code = -1;
                res.Result.Message = "Критическая ошибка";                
            }
            res.ResponseObject = rows;

            return res;
        }

    }
}
