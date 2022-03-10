using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticePay
    {
        public long Id { get; set; }
        public long NoticeId { get; set; }
        public string ViewService { get; set; }
        public int? ProviderCode { get; set; }
        public string GroupName { get; set; }
        public string UnitName { get; set; }
        public string ResourceApartment { get; set; }
        public string ResourceHouse { get; set; }
        public string ServiceRate { get; set; }
        public decimal? ChargeSummApartment { get; set; }
        public decimal? ChargeSummHouse { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? PreviousPeriodRecalcSumm { get; set; }
        public decimal? SaldoPeny { get; set; }
        public decimal? FinalChargeSumm { get; set; }
        public decimal? FinalChargeSummApartment { get; set; }
        public decimal? FinalChargeSummHouse { get; set; }
        public string ExecutorGisName { get; set; }
        public string Num2 { get; set; }
        public string Resource { get; set; }
        public decimal? BenefitSumm { get; set; }
        public decimal? PaymentSumm { get; set; }
        public decimal? ToPaySumm { get; set; }
        public decimal? DebtAdvanceBegin { get; set; }
        public decimal? DebtAdvanceEnd { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? SaldoAdvancePenyBegin { get; set; }
        public decimal? PenaltySumm { get; set; }
        public decimal? SaldoAdvancePenyEnd { get; set; }
        public decimal? ToPaySummEnd { get; set; }
    }
}
