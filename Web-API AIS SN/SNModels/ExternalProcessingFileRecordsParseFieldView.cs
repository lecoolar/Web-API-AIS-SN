using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExternalProcessingFileRecordsParseFieldView
    {
        public long НомерПроцесса { get; set; }
        public long НомерРеестра { get; set; }
        public string Организация { get; set; }
        public string ЛицевойСчет { get; set; }
        public decimal? Оплата { get; set; }
        public decimal? ДопОплата { get; set; }
        public decimal? ПениПоДомам { get; set; }
        public decimal? ПениПоЛицевым { get; set; }
        public string Район { get; set; }
        public string НаселенныйПункт { get; set; }
        public string Улица { get; set; }
        public string Дом { get; set; }
        public string Квартира { get; set; }
        public string Муниципальная { get; set; }
        public string Привотизированная { get; set; }
        public string Комунальный { get; set; }
        public string Аренда { get; set; }
        public string Жилой { get; set; }
        public string Владелиц { get; set; }
        public string ВладелицОрганизации { get; set; }
        public string Прощадь { get; set; }
        public string Тариф { get; set; }
        public string ТарифДата { get; set; }
        public string Период { get; set; }
        public string Сальдо { get; set; }
        public string СльдоДата { get; set; }
        public string Начисления { get; set; }
        public string НачисленияДата { get; set; }
        public string Перерасчет { get; set; }
        public string ПерерасчетДата { get; set; }
        public string ОплатаДата { get; set; }
        public string КонечноеСальдо { get; set; }
        public string КонечноеСальдоДата { get; set; }
    }
}
