using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestServicesView
    {
        public long Id { get; set; }
        public long? RequestId { get; set; }
        public DateTime? Period { get; set; }
        public long? Code { get; set; }
        public string Name { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? BenefitSumm { get; set; }
        public decimal? NachSumm { get; set; }
        public decimal? RecalcSumm { get; set; }
        public decimal? DiffChargeSumm { get; set; }
        public decimal? DiffBenefitSumm { get; set; }
        public decimal? Debt { get; set; }
        public decimal? PositiveDebt { get; set; }
        public decimal? DebtPenalty { get; set; }
        public decimal? Paid { get; set; }
        public decimal Penalty { get; set; }
        public decimal? TotalDebt { get; set; }
        public decimal? DebtToPay { get; set; }
        public decimal? EndDebt { get; set; }
        public int? IsClosed { get; set; }
        public int? IsFixed { get; set; }
        public int? IsCounter { get; set; }
        public long? CounterId { get; set; }
        public decimal? CounterIndication { get; set; }
        public decimal? NewCounterIndication { get; set; }
        public string Consumption { get; set; }
        public decimal? Edk { get; set; }
        public bool IsBankrupt { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? CounterFirstIndication { get; set; }
        public decimal? RateCounter { get; set; }
        public decimal CurrentDebt { get; set; }
        public decimal? CurrentDebtEnd { get; set; }
        public decimal? ChargeSummThreeLastMonths { get; set; }
        public decimal? RecalcSummCurrentMonth { get; set; }
        public decimal? NoticeSumm { get; set; }
        public decimal? RecalcSummNoPayment { get; set; }
        public bool? IsAvailableAvancePayment { get; set; }
        public long? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderPhone { get; set; }
        public long? HouseHolderId { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderName { get; set; }
        public decimal? PositiveDebtPenalty { get; set; }
        public int SignPositiveDebtPenalty { get; set; }
        public string CounterNumber { get; set; }
        public int CounterSize { get; set; }
        public string CounterExternalCode { get; set; }
        public decimal? SaldoEnd { get; set; }
        public decimal? OpenPeriodPositiveDebt { get; set; }
        public decimal? OpenPeriodPositiveDebtPenalty { get; set; }
        public decimal? SaldoEndPenalty { get; set; }
        public int? IsInsurance { get; set; }
        public decimal? OpenPeriodChargeSumm { get; set; }
        public decimal? DebtToPayWithoutPenalty { get; set; }
        public decimal? PaidPenalty { get; set; }
        public decimal? CurrentDebtPenalty { get; set; }
        public int IsCashless { get; set; }
        public bool IsFictive { get; set; }
        public decimal? NegativeDebt { get; set; }
        public string PayCode { get; set; }
        public string PayAccount { get; set; }
        public decimal? CommissionPercent { get; set; }
    }
}
