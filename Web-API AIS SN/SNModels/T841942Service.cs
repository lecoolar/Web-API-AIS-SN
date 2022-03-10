using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T841942Service
    {
        public long Id { get; set; }
        public long TypeId { get; set; }
        public long ProviderId { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public long? CanonicalId { get; set; }
        public long? AlgorithmId { get; set; }
        public decimal? ClUsl { get; set; }
        public decimal? ObjUsl { get; set; }
        public long? HouseHolderId { get; set; }
        public long? ResourceProviderId { get; set; }
        public long? AdrId { get; set; }
        public int? IsSeasonal { get; set; }
        public int IsFixedPayment { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int MonthShift { get; set; }
        public long? OrgDocId { get; set; }
        public bool CanHaveNegativeCharge { get; set; }
        public bool CanRecalcInCloseAccount { get; set; }
        public string Comment { get; set; }
        public bool? IsBankrupt { get; set; }
        public bool IsNotRecalculationOldPeriod { get; set; }
        public bool? UsePaymentPeriodForCounterPeriod { get; set; }
        public int? RecalculationOldPeriodCountMonth { get; set; }
        public bool? IsRecalcOldPeriodWithDifferenceVolume { get; set; }
        public int? RecalcOldPeriodWithDifferenceVolumeCountMonth { get; set; }
        public bool IsAvailableAvancePayment { get; set; }
        public bool OffBalance { get; set; }
        public long? FinancialCenterId { get; set; }
        public int? ApartmentTypeFasetItemId { get; set; }
        public bool? UseChargePeriodCloseService { get; set; }
        public int? PersonalDayPenalty { get; set; }
        public bool? IsArchived { get; set; }
        public int AddPenaltyDays { get; set; }
        public bool? IsTransferPaymentRestriction { get; set; }
        public bool IsUseInPaymentWithClosedAvance { get; set; }
        public bool? IsNds { get; set; }
        public long? GeneralContractorId { get; set; }
        public long? ExecutorGisId { get; set; }
        public int CalcAccuracyCount { get; set; }
        public bool IsNotRecalc { get; set; }
        public bool? NotUseDeltaLastPeriod { get; set; }
    }
}
