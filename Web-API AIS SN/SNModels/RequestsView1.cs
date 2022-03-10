using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestsView1
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public string PaymentSystem { get; set; }
        public long? PaymentSystemId { get; set; }
        public string Organization { get; set; }
        public string Office { get; set; }
        public string Terminal { get; set; }
        public string Operator { get; set; }
        public string AccountNumber { get; set; }
        public long? HouseHolderId { get; set; }
        public DateTime? Period { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string AccountId { get; set; }
        public string AddressName { get; set; }
        public string OwnerName { get; set; }
        public string ApartmentType { get; set; }
        public decimal? ApartmentTotalSquare { get; set; }
        public int? ResidentsCount { get; set; }
        public int? ResidentVacationsCount { get; set; }
        public decimal? CurrentChargeSumm { get; set; }
        public decimal? CurrentBenefitSumm { get; set; }
        public decimal? CurrentRecalcSumm { get; set; }
        public decimal? DiffChargeSumm { get; set; }
        public decimal? DiffBenefitSumm { get; set; }
        public decimal? TotalDebt { get; set; }
        public decimal? TotalPositiveDebt { get; set; }
        public decimal? TotalDebtPenalty { get; set; }
        public decimal? TotalPenalty { get; set; }
        public string Comments { get; set; }
        public string AdditionalInfo { get; set; }
        public string Error { get; set; }
        public long? CalcId { get; set; }
        public decimal? PaidSumm { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public int? RequestTypeFasetId { get; set; }
        public string RequestType { get; set; }
        public string ExternalTransactionId { get; set; }
        public long? ReverseRequestId { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime? ProcessedAt { get; set; }
        public long? GroupOperId { get; set; }
        public string Status { get; set; }
        public int ReverseStatus { get; set; }
        public long? AgentId { get; set; }
        public string AgentName { get; set; }
        public string PaymentOrderNumber { get; set; }
        public DateTime? PaymentOrderDate { get; set; }
        public string PackNumber { get; set; }
        public bool? IsByNotice { get; set; }
        public int? CashFlowTypeId { get; set; }
        public string CashFlowType { get; set; }
        public bool? IsManualReturn { get; set; }
        public bool? IsTransferPayment { get; set; }
        public bool UseBankrupt { get; set; }
        public bool NeedServiceCollapse { get; set; }
        public DateTime? CounterPeriod { get; set; }
        public bool ShowClosedAdvances { get; set; }
        public decimal? Commission { get; set; }
        public bool? NotUseInsurance { get; set; }
        public decimal? InsuranceSumm { get; set; }
        public bool UsePaymentDate { get; set; }
        public int CashPaymentOrderType { get; set; }
        public int? SubService { get; set; }
        public string SubServiceName { get; set; }
        public string ServiceCode { get; set; }
        public bool IsReester { get; set; }
        public int? ReesterTypeId { get; set; }
        public string CashOrderPayment { get; set; }
        public long? ReesterRecordId { get; set; }
        public long? PaymentOrderPackId { get; set; }
        public long? DebtDocumentId { get; set; }
        public bool? IsDebt { get; set; }
        public long? PaymentOrderId { get; set; }
        public DateTime? RequestPeriod { get; set; }
        public long? DebtActionId { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public long? FinancialCenterId { get; set; }
        public string FinancialCenterName { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public int? DistributionType { get; set; }
        public string HouseHolder { get; set; }
        public long? HouseHolderCode { get; set; }
        public bool? PayCurrentReceipt { get; set; }
        public decimal? PaidPenalty { get; set; }
        public long? PinpadCode { get; set; }
        public string PinpadData { get; set; }
        public int? GroupType { get; set; }
        public bool UsePaidPenalty { get; set; }
        public bool? Penalty3Year { get; set; }
        public int? AccountProviderCode { get; set; }
        public string AccountEpd { get; set; }
        public bool WithoutFixed { get; set; }
        public bool WithoutClosed { get; set; }
        public bool? IsChargePenalty { get; set; }
        public bool? IsMaxPeriod { get; set; }
        public bool? IsShowClosedServicesWithoutSaldo { get; set; }
        public int? CounterWoauth { get; set; }
        public DateTime? MinDebtPeriod { get; set; }
        public bool IsServiceOnlyCounters { get; set; }
        public bool IsUseUkgroupCode { get; set; }
        public long? DebtAffairOwnerId { get; set; }
        public bool? IsPayFixed { get; set; }
    }
}
