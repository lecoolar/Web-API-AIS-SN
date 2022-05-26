using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Web_API_AIS_SN.LibClass;
using Web_API_AIS_SN.Model;

namespace Web_API_AIS_SN.GKH
{
    public class Fasets
    {
        public int? BaseId { get; set; }
        public string Uid { get; set; }
        public class Faset
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public Fasets(List<Param> @params, string globalUid = "")
        {
            var bId = @params.FirstOrDefault(q => q.Name == "baseId")?.Value;
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId);
            Uid = globalUid;
        }

        public async Task<ResponseData> GetFasets()
        {
            var rows = new List<Dictionary<string, object>>();
            var res = new ResponseData();
            var constring = "";
            if (BaseId == null || BaseId == 0)
            {
                res.Result.Code = 1;
                res.Result.Message = String.Format(Uid + " Не указан обязательный параметр №базы, требуется уточнение параметра");
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

            var fasets = new FasetSN(constring).GetAll().Select(f => new Faset { Id = f.Id, Name = f.Name });
            PropertyInfo[] Props = typeof(Faset).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var item in fasets)
            {
                var row = new Dictionary<string, object>();
                for (int i = 0; i < Props.Length; i++)
                {
                    row.Add(Props[i].Name, Props[i].GetValue(item, null));
                }
                rows.Add(row);
            }

            if (rows.Any())
            {
                res.ResponseObject = rows;
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
