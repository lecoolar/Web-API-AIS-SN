using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Room
    {
        public Guid? Roomguid { get; set; }
        public string Flatnumber { get; set; }
        public int? Flattype { get; set; }
        public string Roomnumber { get; set; }
        public int? Roomtype { get; set; }
        public string Regioncode { get; set; }
        public string Postalcode { get; set; }
        public DateTime? Updatedate { get; set; }
        public Guid? Houseguid { get; set; }
        public Guid Roomid { get; set; }
        public Guid? Previd { get; set; }
        public Guid? Nextid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Livestatus { get; set; }
        public Guid? Normdoc { get; set; }
        public int? Operstatus { get; set; }
        public string Cadnum { get; set; }
        public string Roomcadnum { get; set; }
    }
}
