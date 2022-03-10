using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcNodeCurrentCharge
    {
        public long CalcNodeId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public decimal? OldChargeSumm { get; set; }
        public decimal? OldBenefitSumm { get; set; }
    }
}
