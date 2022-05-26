using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;
using Web_API_AIS_SN.SNModels;

namespace Web_API_AIS_SN.GKH
{
    public class Residents
    {
        private string Account { get; set; }
        private int? BaseId { get; set; }
        public string Uid { get; set; }

        public Residents(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            var bufaccount = @params.Where(q => q.Name == "account").FirstOrDefault();
            Account = bufaccount == null ? "" : bufaccount.Value == null ? "" : bufaccount.Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : String.IsNullOrEmpty(bId.Value) ? (int?)null : Convert.ToInt32(bId.Value);
        }

        public async Task<ResponseData> GetResidents()
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

            constring = new Helpers().GetConnectionString(BaseId.Value);

            if (String.IsNullOrEmpty(constring))
            {
                res.Result.Code = 11;
                res.Result.Message = $"{Uid}  Ошибка, не удалось собрать строку подключения к базе!";
                return res;
            }

            var acc = new AccountSN(constring).GetByNumber(Account);
            var userPermisson = new Helpers().CheckUserPermisson(constring, acc?.Id ?? 0);
            if (userPermisson && acc != null)
            {
                var residents = new ApartmentResidentSN(constring).FindByApartment(acc.ApartmentId);
                PropertyInfo[] Props = typeof(ApartmentResidentsView).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (var item in residents)
                {
                    var row = new Dictionary<string, object>();
                    for (int i = 0; i < Props.Length; i++)
                    {
                        Type t = Props[i].PropertyType;
                        if (t.Equals(typeof(DateTime)) || t.Equals(typeof(DateTime?)))
                        {
                            var date = Convert.ToDateTime(Props[i].GetValue(item, null));
                            row.Add(Props[i].Name, date == DateTime.MinValue ? null : date.ToString("d"));
                        }
                        else
                        {
                            row.Add(Props[i].Name, Props[i].GetValue(item, null));
                        }
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
                res.Result.Message = "По указанным данным информация не найдена";
            }
            return res;
        }
    }
}
