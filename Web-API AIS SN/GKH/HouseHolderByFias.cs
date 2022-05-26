using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;

namespace Web_API_AIS_SN.GKH
{
    public class HouseHolderByFias
    {
        public string FiasCode { get; set; }
        public string Uid { get; set; }

        public HouseHolderByFias(List<Param> @params, string globalUid = "")
        {
            FiasCode = @params.FirstOrDefault(q => q.Name == "fiasCode")?.Value;
            Uid = globalUid;
        }
        public async Task<ResponseData> GetHouseHolderByFias()
        {
            var res = new ResponseData();
            try
            {
                long baseId;
                using (var smsr = new SMSRContext())
                {
                    baseId = smsr.AccountInfos.FirstOrDefault(f => f.FiasCode == FiasCode)?.BaseId ?? 0;
                }
                var constring = new Helpers().GetConnectionString(baseId);

                if (String.IsNullOrEmpty(constring))
                {
                    res.Result.Code = 11;
                    res.Result.Message = $"fiasCode не найден!";
                    return res;
                }
                else
                {

                    var houseHolder = new HouseHoldersSN(constring).GetByFias(FiasCode);
                    if (houseHolder != null)
                    {
                        var row = new Dictionary<string, object>();
                        row.Add("orgId", houseHolder.Id);
                        row.Add("organizationName", houseHolder.HouseHolderName);
                        row.Add("organizationINN", houseHolder.Inn);
                        row.Add("organizationOGRN", houseHolder.Ogrn);
                        row.Add("organizationKPP", houseHolder.Kpp);
                        row.Add("organizationCode", houseHolder.HouseHolderCode);
                        res.ResponseObject.Add(row);
                    }
                    else
                    {
                        res.Result.Code = 2;
                        res.Result.Message = "По указанным данным информация не найдена";
                    }
                }
            }
            catch (Exception ex)
            {
                res.Result.Code = -1;
                res.Result.Message = "Критическая ошибка.";
            }
            return res;
        }
    }
}
