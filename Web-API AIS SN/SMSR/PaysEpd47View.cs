using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaysEpd47View
    {
        public string Район { get; set; }
        public DateTime? ДатаСозданияПлатежа { get; set; }
        public string Логин { get; set; }
        public decimal? СуммаПлатежа { get; set; }
        public string ЛицевойСчет { get; set; }
        public DateTime? ДатаПроведенияПлатежа { get; set; }
        public DateTime? ПериодОплаты { get; set; }
        public string СостояниеПлатежа { get; set; }
        public string ОтветБанка { get; set; }
    }
}
