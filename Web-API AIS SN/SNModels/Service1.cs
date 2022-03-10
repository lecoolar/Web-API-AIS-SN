using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Service1
    {
        public Service1()
        {
            AccountService4s = new HashSet<AccountService4>();
            HouseAreas = new HashSet<HouseArea>();
            HouseBankAccountServiceTypes = new HashSet<HouseBankAccountServiceType>();
            HouseCounterServiceCounters = new HashSet<HouseCounterServiceCounter>();
            HouseCounterServiceNorms = new HashSet<HouseCounterServiceNorm>();
            HouseCounterServices = new HashSet<HouseCounterService>();
            HouseServiceNormBenefits = new HashSet<HouseServiceNormBenefit>();
            HouseServiceNorms = new HashSet<HouseServiceNorm>();
            HouseServiceRestrictionsOnUnloadings = new HashSet<HouseServiceRestrictionsOnUnloading>();
            HouseServiceSeasons = new HashSet<HouseServiceSeason>();
            HouseServiceTariffs = new HashSet<HouseServiceTariff>();
            HouseTreatyCommitments = new HashSet<HouseTreatyCommitment>();
            JnBenefits = new HashSet<JnBenefit>();
            NormsForElectrics = new HashSet<NormsForElectric>();
            RemitteeServices = new HashSet<RemitteeService>();
            ServiceCalcAlgs = new HashSet<ServiceCalcAlg>();
            ServiceCommissions = new HashSet<ServiceCommission>();
            ServiceNormBenefits = new HashSet<ServiceNormBenefit>();
            ServicePenalties = new HashSet<ServicePenalty>();
            ServiceSeasonals = new HashSet<ServiceSeasonal>();
            ServiceSplitLinks = new HashSet<ServiceSplitLink>();
            ServiceTariffs = new HashSet<ServiceTariff>();
        }

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
        public bool? IsAvailableAvancePayment { get; set; }
        public bool OffBalance { get; set; }
        public long? FinancialCenterId { get; set; }
        public int? ApartmentTypeFasetItemId { get; set; }
        public bool? UseChargePeriodCloseService { get; set; }
        public int? PersonalDayPenalty { get; set; }
        public bool? IsArchived { get; set; }
        public int AddPenaltyDays { get; set; }
        public bool? IsTransferPaymentRestriction { get; set; }
        public bool? IsUseInPaymentWithClosedAvance { get; set; }
        public bool? IsNds { get; set; }
        public long? GeneralContractorId { get; set; }
        public long? ExecutorGisId { get; set; }
        public int CalcAccuracyCount { get; set; }
        public bool IsNotRecalc { get; set; }
        public bool? NotUseDeltaLastPeriod { get; set; }

        public virtual LocalAddress Adr { get; set; }
        public virtual CalcAlg Algorithm { get; set; }
        public virtual FasetItem ApartmentTypeFasetItem { get; set; }
        public virtual CanonicalService1 Canonical { get; set; }
        public virtual Organization1 ExecutorGis { get; set; }
        public virtual Organization1 FinancialCenter { get; set; }
        public virtual Organization1 GeneralContractor { get; set; }
        public virtual Organization1 HouseHolder { get; set; }
        public virtual OrgDocument OrgDoc { get; set; }
        public virtual Organization1 Provider { get; set; }
        public virtual Organization1 ResourceProvider { get; set; }
        public virtual ServiceType Type { get; set; }
        public virtual ServiceGroupLink ServiceGroupLink { get; set; }
        public virtual ICollection<AccountService4> AccountService4s { get; set; }
        public virtual ICollection<HouseArea> HouseAreas { get; set; }
        public virtual ICollection<HouseBankAccountServiceType> HouseBankAccountServiceTypes { get; set; }
        public virtual ICollection<HouseCounterServiceCounter> HouseCounterServiceCounters { get; set; }
        public virtual ICollection<HouseCounterServiceNorm> HouseCounterServiceNorms { get; set; }
        public virtual ICollection<HouseCounterService> HouseCounterServices { get; set; }
        public virtual ICollection<HouseServiceNormBenefit> HouseServiceNormBenefits { get; set; }
        public virtual ICollection<HouseServiceNorm> HouseServiceNorms { get; set; }
        public virtual ICollection<HouseServiceRestrictionsOnUnloading> HouseServiceRestrictionsOnUnloadings { get; set; }
        public virtual ICollection<HouseServiceSeason> HouseServiceSeasons { get; set; }
        public virtual ICollection<HouseServiceTariff> HouseServiceTariffs { get; set; }
        public virtual ICollection<HouseTreatyCommitment> HouseTreatyCommitments { get; set; }
        public virtual ICollection<JnBenefit> JnBenefits { get; set; }
        public virtual ICollection<NormsForElectric> NormsForElectrics { get; set; }
        public virtual ICollection<RemitteeService> RemitteeServices { get; set; }
        public virtual ICollection<ServiceCalcAlg> ServiceCalcAlgs { get; set; }
        public virtual ICollection<ServiceCommission> ServiceCommissions { get; set; }
        public virtual ICollection<ServiceNormBenefit> ServiceNormBenefits { get; set; }
        public virtual ICollection<ServicePenalty> ServicePenalties { get; set; }
        public virtual ICollection<ServiceSeasonal> ServiceSeasonals { get; set; }
        public virtual ICollection<ServiceSplitLink> ServiceSplitLinks { get; set; }
        public virtual ICollection<ServiceTariff> ServiceTariffs { get; set; }
    }
}
