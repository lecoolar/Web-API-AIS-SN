using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class House
    {
        public Guid? Aoguid { get; set; }
        public string Buildnum { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Eststatus { get; set; }
        public Guid? Houseguid { get; set; }
        public Guid Houseid { get; set; }
        public string Housenum { get; set; }
        public int? Statstatus { get; set; }
        public string Ifnsfl { get; set; }
        public string Ifnsul { get; set; }
        public string Okato { get; set; }
        public string Oktmo { get; set; }
        public string Postalcode { get; set; }
        public DateTime? Startdate { get; set; }
        public string Strucnum { get; set; }
        public int? Strstatus { get; set; }
        public string Terrifnsfl { get; set; }
        public string Terrifnsul { get; set; }
        public DateTime? Updatedate { get; set; }
        public Guid? Normdoc { get; set; }
        public int? Counter { get; set; }
        public string Cadnum { get; set; }
        public int? Divtype { get; set; }
        public string Regioncode { get; set; }
    }
}
