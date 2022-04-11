using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;

namespace Web_API_AIS_SN.GKH
{
    public class CountResidentVacation
    {

        private string Account { get; set; }
        private int? BaseId { get; set; }
        public string Uid { get; set; }

        public CountResidentVacation(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            //Request tmp = JsonConvert.DeserializeObject<Request>(param);
            Account = @params.Where(q => q.Name == "account").FirstOrDefault().Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);
        }
        public async Task<ResponseData> GetCountResidentVacation()
        {
            var res = new ResponseData();
            var rows = new List<Dictionary<string, object>>();
            string constring;

            if (BaseId == null || BaseId == 0)
            {
                res.Result.Code = 1;
                res.Result.Message = String.Format("Не указан обязательный параметр №базы, требуется уточнение параметра");
                return res;
            }
            else
            {
                constring = new Helpers().GetConnectionString(BaseId.Value);
            }

            if (String.IsNullOrEmpty(constring))
            {
                res.Result.Code = 11;
                res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                return res;
            }
            else
            {
                var acc = new AccountSN(constring).GetByNumber(Account);
                var userPermisson = new Helpers().CheckUserPermisson(constring, acc?.Id ?? 0);

                if (userPermisson && acc != null)
                {
                    var resCount = new ApartmentResidentVacationSN(constring)
                        .FindByApartmentId(acc.ApartmentId)
                        .Select(v => v.ResidentId)
                        .Distinct().Count();
                    rows.Add(new Dictionary<string, object>
                    {
                        { "countResidentVacation", resCount }
                    });
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
                    res.Result.Message = "По указанным данным информация не найдена";
                }
            }
            return res;
        }
    }
}
