using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Tbl79011
    {
        public long Id { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public DateTime? BirthDate { get; set; }
        public long? Rnk { get; set; }
        public int? Cnt { get; set; }
        public long? PmainId { get; set; }
    }
}
