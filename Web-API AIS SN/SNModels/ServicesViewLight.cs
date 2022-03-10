using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServicesViewLight
    {
        public long Id { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public long? TypeId { get; set; }
        public int? TypeCode { get; set; }
        public string TypeName { get; set; }
        public long? TypeParentId { get; set; }
        public long? ProviderId { get; set; }
        public int? OrgCode { get; set; }
        public string OrgName { get; set; }
        public string ProviderLongName { get; set; }
        public bool? IsBankrupt { get; set; }
        public long? CanonicalId { get; set; }
        public string CanonicalName { get; set; }
        public long? AlgorithmId { get; set; }
        public string AlgorithmName { get; set; }
        public DateTime? CurrentTariffFromDate { get; set; }
        public long? CurrentRateId { get; set; }
        public decimal? CurrentRate { get; set; }
        public DateTime? LastTariffFromDate { get; set; }
        public long? LastRateId { get; set; }
        public decimal? LastRate { get; set; }
        public DateTime? ServiceNormFromDate { get; set; }
        public long? ServiceNormId { get; set; }
        public decimal? ServiceNormRate { get; set; }
        public string ServiceNormUnitName { get; set; }
        public long? HouseHolderId { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderShortName { get; set; }
        public string HouseHolderLongName { get; set; }
        public long? ResourceProviderId { get; set; }
        public int? ResourceProviderCode { get; set; }
        public string ResourceProviderShortName { get; set; }
        public string ResourceProviderLongName { get; set; }
        public long? GeneralContractorId { get; set; }
        public int? GeneralContractorCode { get; set; }
        public string GeneralContractorShortName { get; set; }
        public string GeneralContractorLongName { get; set; }
        public long? AdrId { get; set; }
        public string Adr { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public int? IsSeasonal { get; set; }
        public int? SeasonalCount { get; set; }
        public int? IsFixedPayment { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? ClUsl { get; set; }
        public long? ObjUsl { get; set; }
        public int? MonthShift { get; set; }
        public long? OrgDocId { get; set; }
        public string OrgDocComment { get; set; }
        public bool? CanHaveNegativeCharge { get; set; }
        public bool? CanRecalcInCloseAccount { get; set; }
        public string Comment { get; set; }
        public bool? IsServiceBankrupt { get; set; }
        public bool? IsNotRecalculationOldPeriod { get; set; }
        public int? RecalculationOldPeriodCountMonth { get; set; }
        public bool? IsAvailableAvancePayment { get; set; }
        public bool? IsRecalcOldPeriodWithDifferenceVolume { get; set; }
        public int? RecalcOldPeriodWithDifferenceVolumeCountMonth { get; set; }
        public bool? OffBalance { get; set; }
        public long? FinancialCenterId { get; set; }
        public int? FinancialCenterCode { get; set; }
        public string FinancialCenterShortName { get; set; }
        public string FinancialCenterLongName { get; set; }
        public bool? IsFinancialCenter { get; set; }
        public int? ApartmentTypeFasetItemId { get; set; }
        public string ApartmentTypeFasetItemName { get; set; }
        public bool? UseChargePeriodCloseService { get; set; }
        public int? PersonalDayPenalty { get; set; }
        public bool? IsArchived { get; set; }
        public int? AddPenaltyDays { get; set; }
        public bool? IsTransferPaymentRestriction { get; set; }
        public bool? IsUseInPaymentWithClosedAvance { get; set; }
        public bool? IsNds { get; set; }
        public int? CalcAccuracyCount { get; set; }
        public long? ExecutorGisId { get; set; }
        public string ExecutorGisName { get; set; }
        public bool? IsNotRecalc { get; set; }
        public bool? NotUseDeltaLastPeriod { get; set; }
    }
}
