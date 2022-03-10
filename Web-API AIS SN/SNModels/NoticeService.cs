using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeService
    {
        public NoticeService()
        {
            NoticeServiceByPeriods = new HashSet<NoticeServiceByPeriod>();
            NoticeServiceCounters = new HashSet<NoticeServiceCounter>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long NoticeId { get; set; }
        public long? AccountServiceId { get; set; }
        public long? ServiceId { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public string GroupName { get; set; }
        public int? GroupCode { get; set; }
        public string ParentName { get; set; }
        public int? ParentCode { get; set; }
        public string ViewService { get; set; }
        public bool? IsOpenSrv { get; set; }
        public decimal? ServiceRate { get; set; }
        public decimal? ServiceNorm { get; set; }
        public string UnitName { get; set; }
        public string ServiceNormUnitName { get; set; }
        public decimal? CalcSquare { get; set; }
        public string ProviderName { get; set; }
        public decimal? Debt { get; set; }
        public decimal? RecalcSumm { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? BenefitSumm { get; set; }
        public decimal? PaymentSumm { get; set; }
        public decimal? PreviousPeriodPaymentSumm { get; set; }
        public decimal? PreviousPeriodRecalcSumm { get; set; }
        public decimal? PreviousPeriodRecalcSummByCreated { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? Edk { get; set; }
        public string ServiceNormByUnitName { get; set; }
        public bool IsExistCounter { get; set; }
        public decimal? CashlessSumm { get; set; }
        public string ServiceUnitName { get; set; }
        public DateTime? DateLastPayment { get; set; }
        public decimal? ServiceSubRate { get; set; }
        public decimal? BenefitRecSumm { get; set; }
        public decimal? OplEdksumm { get; set; }
        public decimal? OplSubsidSumm { get; set; }
        public decimal? ServiceOriginalNorm { get; set; }
        public decimal? ServiceOriginalRate { get; set; }
        public decimal? ChargeSummByPeriod { get; set; }
        public decimal? RecalcSummByPeriod { get; set; }
        public bool? IsExistAnySumm { get; set; }
        public bool? IsHouseCharge { get; set; }
        public decimal? IsTransBenefit { get; set; }
        public decimal? BenefitDebtVolume { get; set; }
        public decimal? BenefitTransSumm { get; set; }
        public decimal? BenefitRecalcSummByServiceType { get; set; }
        public decimal? BenefitChargeSummByServiceType { get; set; }
        public bool? IsBankrupt { get; set; }
        public long? HouseHolderId { get; set; }
        public long? ProviderId { get; set; }
        public decimal? SpecialRecalcFutureSummByOldPeriod { get; set; }
        public decimal? SpecialRecalcFutureSummByCurrentPeriod { get; set; }
        public decimal? SpecialRecalcSummByOldPeriod { get; set; }
        public decimal? PenaltySumm { get; set; }
        public decimal? InfoNormRateCalcByDiv { get; set; }
        public decimal? CalcPenaltySumm { get; set; }
        public decimal? DebtInfo { get; set; }
        public decimal? SaldoPeny { get; set; }
        public long? FinancialCenterId { get; set; }
        public decimal? MonetizedBenefitSumm { get; set; }
        public decimal? MonetizedBenefitRecSumm { get; set; }
        public int? ServiceApartmentTypeId { get; set; }
        public decimal? PreviousPeriodCashlessSumm { get; set; }
        public decimal? BenefitPrevRecSumm { get; set; }
        public decimal? MonetizedBenefitPrevRecSumm { get; set; }
        public decimal? InfoRateGiga { get; set; }
        public decimal? InfoNormGiga { get; set; }
        public int? DebtCountPeriod { get; set; }
        public DateTime? EdkFromDate { get; set; }
        public DateTime? EdkToDate { get; set; }
        public string EdkOwnerName { get; set; }
        public decimal? SummLastPayment { get; set; }
        public decimal? ServiceSubNoticeRate { get; set; }
        public long? ExecutorGisId { get; set; }
        public bool? LastPaymentIsIncomingTransferDate { get; set; }
        public decimal? SaldoBeginInfo { get; set; }
        public int? IsIncomingService { get; set; }
        public decimal? FinalChargeSummInfo { get; set; }
        public decimal? SaldoEndInfo { get; set; }
        public DateTime? PeriodDebt { get; set; }
        public decimal? FuturePeriodRecalcSummByCreated { get; set; }
        public decimal? FuturePeriodCashlessSummByCreated { get; set; }
        public decimal? BenefitFutureRecSummByCreated { get; set; }
        public decimal? MonetizedBenefitFutureRecSummByCreated { get; set; }
        public decimal? SaldoBeginPenyInfo { get; set; }
        public decimal? IncDecChargePenalty { get; set; }

        public virtual Notice Notice { get; set; }
        public virtual ICollection<NoticeServiceByPeriod> NoticeServiceByPeriods { get; set; }
        public virtual ICollection<NoticeServiceCounter> NoticeServiceCounters { get; set; }
    }
}
