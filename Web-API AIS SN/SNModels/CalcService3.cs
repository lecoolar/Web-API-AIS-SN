using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcService3
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long CalcId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public decimal? OldChargeSumm { get; set; }
        public decimal? OldBenefitSumm { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? BenefitSumm { get; set; }
        public decimal? Delta { get; set; }
        public decimal? CsbdSumm { get; set; }
        public int? RowNumber { get; set; }
        public bool? IsMonetization { get; set; }
        public bool IsSave { get; set; }
        public DateTime? Created { get; set; }
        public long? Oldid { get; set; }
    }
}
