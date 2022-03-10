using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T80040
    {
        public string Договор { get; set; }
        public string ТочкаУчета { get; set; }
        public string Абонент { get; set; }
        public string Адрес { get; set; }
        public string МодельПрибора { get; set; }
        public string Разрядность { get; set; }
        public string СерийныйНомер { get; set; }
        public string ДатаСнятия { get; set; }
        public string День { get; set; }
        public string Ночь { get; set; }
        public string Ind3 { get; set; }
        public string Код { get; set; }
    }
}
