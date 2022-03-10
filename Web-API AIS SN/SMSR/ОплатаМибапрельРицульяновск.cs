using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ОплатаМибапрельРицульяновск
    {
        public double? Пп { get; set; }
        public string Номерзаказа { get; set; }
        public double? Уникальныйномерплатежа { get; set; }
        public DateTime? Датаплатежа { get; set; }
        public double? Сумма { get; set; }
        public double? Суммакомиссии { get; set; }
    }
}
