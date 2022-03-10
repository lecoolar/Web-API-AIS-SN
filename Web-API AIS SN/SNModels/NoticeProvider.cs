using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeProvider
    {
        public long Id { get; set; }
        public long NoticeId { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public string AddrInfo { get; set; }
        public decimal? BeginSaldoSumm { get; set; }
        public decimal? BeginAdvanceSumm { get; set; }
        public decimal? FinalChargeSumm { get; set; }
        public decimal? PaymentSumm { get; set; }
        public decimal? BeginSaldoNextPeriodSumm { get; set; }
        public decimal? BeginAdvanceNextPeriodSumm { get; set; }
        public decimal? ToPaySumm { get; set; }
    }
}
