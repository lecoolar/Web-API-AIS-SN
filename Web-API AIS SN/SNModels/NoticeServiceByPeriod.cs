using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeServiceByPeriod
    {
        public long Id { get; set; }
        public long NoticeServiceId { get; set; }
        public DateTime Period { get; set; }
        public int? GroupOperSubTypeId { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? RecalcSumm { get; set; }
        public long? GroupOperId { get; set; }
        public decimal? SpecialRecalcFutureSummByOldPeriod { get; set; }
        public decimal? SpecialRecalcFutureSummByCurrentPeriod { get; set; }
        public decimal? SpecialRecalcSummByOldPeriod { get; set; }
        public decimal? CashlessSumm { get; set; }
        public decimal? PenaltySumm { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? IncDecChargePenalty { get; set; }

        public virtual NoticeService NoticeService { get; set; }
    }
}
