using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestAccountServicePenalty
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public DateTime PayDate { get; set; }
        public decimal? RefinancingRate { get; set; }
        public decimal? Debt { get; set; }
        public int? DebtDays { get; set; }
        public int? DebtDays130 { get; set; }
        public int? DebtDays300 { get; set; }
        public decimal? DebtPenalty { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? Penalty130 { get; set; }
        public decimal? Penalty300 { get; set; }
        public decimal? DebtCredit { get; set; }
        public int? DebtDays170 { get; set; }
        public decimal? Penalty170 { get; set; }
    }
}
