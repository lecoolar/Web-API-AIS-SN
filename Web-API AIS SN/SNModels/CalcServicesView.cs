using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServicesView
    {
        public long Id { get; set; }
        public long CalcId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceShortName { get; set; }
        public decimal? OldChargeSumm { get; set; }
        public decimal? OldBenefitSumm { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? BenefitSumm { get; set; }
        public decimal? DiffChargeSumm { get; set; }
        public decimal? DiffBenefitSumm { get; set; }
    }
}
