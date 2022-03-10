using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Calc2
    {
        public long Id { get; set; }
        public long CalcId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int CalcStatus { get; set; }
        public long UserId { get; set; }

        public virtual User User { get; set; }
    }
}
