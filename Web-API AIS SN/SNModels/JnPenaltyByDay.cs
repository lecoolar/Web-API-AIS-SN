using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnPenaltyByDay
    {
        public long Id { get; set; }
        public long JnId { get; set; }
        public DateTime Period { get; set; }
        public DateTime PayDate { get; set; }
        public int? DayCount { get; set; }
        public decimal? BeginDebt { get; set; }
        public decimal? Debt { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ByCoef { get; set; }
        public decimal? Penalty { get; set; }
        public int? CountDayAll { get; set; }
        public int? DayCoef { get; set; }
        public int? Split { get; set; }
        public int? ModeCalc { get; set; }

        public virtual Jn1 Jn { get; set; }
    }
}
