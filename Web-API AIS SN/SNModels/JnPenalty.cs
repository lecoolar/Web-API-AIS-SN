using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnPenalty
    {
        public long Id { get; set; }
        public long JnId { get; set; }
        public DateTime Period { get; set; }
        public DateTime DayCalcPenalty { get; set; }
        public DateTime? PrefDayCalcPenalty { get; set; }
        public decimal RefinancingRate { get; set; }
        public decimal Penalty130 { get; set; }
        public decimal Penalty300 { get; set; }
        public decimal Debt { get; set; }
        public int DebtDays { get; set; }
        public int DebtDays130 { get; set; }
        public int DebtDays300 { get; set; }
        public int? PrefDays { get; set; }
        public int? PrefDays130 { get; set; }
        public int? PrefDays300 { get; set; }
        public decimal Penalty130Charge { get; set; }
        public decimal Penalty300Charge { get; set; }
        public decimal? DebtCredit { get; set; }
        public string UiFormula { get; set; }
        public decimal Penalty170 { get; set; }
        public int DebtDays170 { get; set; }
        public int? PrefDays170 { get; set; }
        public decimal Penalty170Charge { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? PenaltyCharge { get; set; }
        public byte? Suspension { get; set; }

        public virtual Jn1 Jn { get; set; }
    }
}
