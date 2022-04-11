using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API_AIS_SN.Context;
using Web_API_AIS_SN.GKH;
using Web_API_AIS_SN.Model;

namespace Web_API_AIS_SN.NoticeAndReport
{
    public class FindTypeNotice
    {
        public string Account { get; set; }
        public string Uid { get; set; }

        public int? BaseId { get; set; }

        public FindTypeNotice(List<Param> @params, string globalUid = "")
        {
            Uid = globalUid;
            Account = @params.Where(q => q.Name == "account").FirstOrDefault().Value;
            var bId = @params.Where(q => q.Name == "baseId").FirstOrDefault();
            BaseId = bId == null ? (int?)null : Convert.ToInt32(bId.Value);
        }

        public async Task<NoticeData> GetFindTypeNotice()
        {
            var res = new NoticeData();
            List<NoticeCase> responseObject = new List<NoticeCase>();
            var values = Enum.GetValues(typeof(NoticeType));
            foreach (var item in values)
            {
                var buf = new NoticeCase();
                buf.Type = (NoticeType)item;

                //buf.typeCode = (int)item;
#warning add appsettings
                if ("yes"== "yes")
                    buf.Activ = true;
                switch ((int)buf.Type)
                {
                    case 0:
                        buf.TypeName = "Справка по лицевому счету";
                        break;
                    case 1:
                        buf.TypeName = "Справка из бухгалтерии";
                        break;
                    case 2:
                        buf.TypeName = "Справка по задолженности";
                        break;
                    case 3:
                        buf.TypeName = "Сальдо краткое";
                        break;
                    case 4:
                        buf.TypeName = "Сальдо расширенное";
                        break;
                    case 5://
                        buf.TypeName = "Сальдо";
                        break;
                    case 6://
                        buf.TypeName = "Начисление";
                        break;
                    default:
                        buf.TypeName = "";
                        break;
                }
                res.ResponseObject.Add(buf);
            }
            return res;
        }
    }
}

