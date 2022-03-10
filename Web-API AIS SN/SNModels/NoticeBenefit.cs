using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeBenefit
    {
        public long NoticeId { get; set; }
        public long AccountServiceId { get; set; }
        public long PersonId { get; set; }
        public decimal? BenefitChargeSumm { get; set; }
        public decimal? BenefitRecalcSumm { get; set; }
        public bool? IsTransBenefit { get; set; }
        public decimal? SpecialBenefitRecalcFutureSummByCurrentPeriod { get; set; }
        public long? BenefitId { get; set; }
    }
}
