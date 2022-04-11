using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.GKH;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.ResultModels;

namespace Web_API_AIS_SN.LK
{
    public class PaysLK
    {
        public string Account { get; set; }
        public int? BaseId { get; set; }
        public string Phone { get; set; }
        public string Uid { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public PaysLK(List<Param> @params, string globalUid = "")
        {
            var bufaccount = @params.FirstOrDefault(q => q.Name == "account")?.Value;
            Account = bufaccount == null ? "" : bufaccount;
            var bufphone = @params.FirstOrDefault(q => q.Name == "phone")?.Value;
            Phone = bufphone == null ? "" : bufphone;

            var bId = @params.FirstOrDefault(q => q.Name == "baseId")?.Value;
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId);

            var date = new DateTime();
            var bifdate = @params.FirstOrDefault(q => q.Name == "fromDate")?.Value;
            DateTime.TryParse(bifdate == null ? "01-01-1900" : bifdate, out date);
            FromDate = date;
            bifdate = @params.FirstOrDefault(q => q.Name == "toDate")?.Value;
            DateTime.TryParse(bifdate == null ? DateTime.Now.ToString() : bifdate, out date);
            ToDate = date;
        }

        public async Task<ListPayLk> GetPaysLK()
        {
            var res = new ListPayLk();
            var paysLK = new List<GetPaysLKResult>();
            if (string.IsNullOrEmpty(Account) && string.IsNullOrEmpty(Phone))
            {
                res.Result.Code = 1;
                res.Result.Message = String.Format("Не указан ни один параметр для поиска(ЛС и телефон)");
            }
            else
            {
                using (var smsr = new SMSRContext())
                {
                    string query = @$"SELECT * FROM CRM.""GetPaysLK""({Account},{Phone},{FromDate},{ToDate})";
                    paysLK = await smsr.Set<GetPaysLKResult>().FromSqlRaw(query).ToListAsync();
                    //paysLK = smsr.GetPaysLK(Account, Phone, FromDate, ToDate).ToList();
                    var wsw = smsr.WebServices.FirstOrDefault(w => w.Id == BaseId);
                    var serviceCode = smsr.PaymentServices
                            .Where(p => p.WebServiceId == BaseId && p.IsActive)
                            .Select(s => s.ServiceCode.ToString()).ToList();

                    serviceCode.Add(wsw.Srvnum.ToString());

                    paysLK = paysLK
                            .Where(p => (p.Accpu == Account && serviceCode.Contains(p.Service)) || p.Phone == Phone)
                            .ToList();

                }
                if (paysLK.Any())
                {
                    res.Result.Code = 0;
                    res.ResponseObject = paysLK;
                }
                else
                {
                    res.Result.Code = 2;
                    res.Result.Message = "По указанному лицевому счету информация об оплатах не найдена";
                }
            }
            return res;
        }
    }

    public class ListPayLk
    {
        public BaseResult Result { get; set; }
        public List<GetPaysLKResult> ResponseObject { get; set; }

        public ListPayLk()
        {
            Result = new BaseResult();
            ResponseObject = new List<GetPaysLKResult>();
        }
    }
}
