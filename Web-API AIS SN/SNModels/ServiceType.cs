using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceType
    {
        public ServiceType()
        {
            AccountDocuments = new HashSet<AccountDocument>();
            ApartmentCounters = new HashSet<ApartmentCounter>();
            ApartmentResidentBenefits = new HashSet<ApartmentResidentBenefit>();
            ApartmentResidentVacationServiceTypes = new HashSet<ApartmentResidentVacationServiceType>();
            BenefitDebts = new HashSet<BenefitDebt>();
            BenefitServiceTypeLinks = new HashSet<BenefitServiceTypeLink>();
            CanonicalService1s = new HashSet<CanonicalService1>();
            HouseCounter2s = new HashSet<HouseCounter2>();
            HouseCounterDelta = new HashSet<HouseCounterDeltum>();
            HouseResourceProviders = new HashSet<HouseResourceProvider>();
            HouseServiceNormBenefits = new HashSet<HouseServiceNormBenefit>();
            HouseServiceNorms = new HashSet<HouseServiceNorm>();
            HouseServiceProviders = new HashSet<HouseServiceProvider>();
            HouseServiceRestrictionsOnUnloadings = new HashSet<HouseServiceRestrictionsOnUnloading>();
            HouseServiceTariffs = new HashSet<HouseServiceTariff>();
            HouseTreatyCommitments = new HashSet<HouseTreatyCommitment>();
            InverseParent = new HashSet<ServiceType>();
            JnBenefitAccounts = new HashSet<JnBenefitAccount>();
            NormsForElectrics = new HashSet<NormsForElectric>();
            Service1s = new HashSet<Service1>();
            ServiceTypeContexts = new HashSet<ServiceTypeContext>();
            ServiceTypeGroupChildren = new HashSet<ServiceTypeGroup>();
            ServiceTypeGroupParents = new HashSet<ServiceTypeGroup>();
            ServiceTypeReplacementChildren = new HashSet<ServiceTypeReplacement>();
            ServiceTypeReplacementParents = new HashSet<ServiceTypeReplacement>();
            ServiceTypeSubQualities = new HashSet<ServiceTypeSubQuality>();
            ServiceTypeSubQualityAliases = new HashSet<ServiceTypeSubQualityAlias>();
            ServiceTypeSubstitutionDestinationServiceTypes = new HashSet<ServiceTypeSubstitution>();
            ServiceTypeSubstitutionSourceServiceTypeIdByReportNavigations = new HashSet<ServiceTypeSubstitution>();
            ServiceTypeSubstitutionSourceServiceTypes = new HashSet<ServiceTypeSubstitution>();
            ServiceTypeSynonyms = new HashSet<ServiceTypeSynonym>();
            UserServiceTypes = new HashSet<UserServiceType>();
        }

        public long Id { get; set; }
        public int? Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int? UnitId { get; set; }
        public long? ClT { get; set; }
        public long? ObjT { get; set; }
        public long? ParentId { get; set; }
        public int IsGroup { get; set; }
        public int? TypeId { get; set; }
        public string UnloadDbfName { get; set; }
        public string ExternalCode { get; set; }
        public int? ExternalCodeId { get; set; }

        public virtual ServiceType Parent { get; set; }
        public virtual FasetItem Type { get; set; }
        public virtual FasetItem Unit { get; set; }
        public virtual ICollection<AccountDocument> AccountDocuments { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounters { get; set; }
        public virtual ICollection<ApartmentResidentBenefit> ApartmentResidentBenefits { get; set; }
        public virtual ICollection<ApartmentResidentVacationServiceType> ApartmentResidentVacationServiceTypes { get; set; }
        public virtual ICollection<BenefitDebt> BenefitDebts { get; set; }
        public virtual ICollection<BenefitServiceTypeLink> BenefitServiceTypeLinks { get; set; }
        public virtual ICollection<CanonicalService1> CanonicalService1s { get; set; }
        public virtual ICollection<HouseCounter2> HouseCounter2s { get; set; }
        public virtual ICollection<HouseCounterDeltum> HouseCounterDelta { get; set; }
        public virtual ICollection<HouseResourceProvider> HouseResourceProviders { get; set; }
        public virtual ICollection<HouseServiceNormBenefit> HouseServiceNormBenefits { get; set; }
        public virtual ICollection<HouseServiceNorm> HouseServiceNorms { get; set; }
        public virtual ICollection<HouseServiceProvider> HouseServiceProviders { get; set; }
        public virtual ICollection<HouseServiceRestrictionsOnUnloading> HouseServiceRestrictionsOnUnloadings { get; set; }
        public virtual ICollection<HouseServiceTariff> HouseServiceTariffs { get; set; }
        public virtual ICollection<HouseTreatyCommitment> HouseTreatyCommitments { get; set; }
        public virtual ICollection<ServiceType> InverseParent { get; set; }
        public virtual ICollection<JnBenefitAccount> JnBenefitAccounts { get; set; }
        public virtual ICollection<NormsForElectric> NormsForElectrics { get; set; }
        public virtual ICollection<Service1> Service1s { get; set; }
        public virtual ICollection<ServiceTypeContext> ServiceTypeContexts { get; set; }
        public virtual ICollection<ServiceTypeGroup> ServiceTypeGroupChildren { get; set; }
        public virtual ICollection<ServiceTypeGroup> ServiceTypeGroupParents { get; set; }
        public virtual ICollection<ServiceTypeReplacement> ServiceTypeReplacementChildren { get; set; }
        public virtual ICollection<ServiceTypeReplacement> ServiceTypeReplacementParents { get; set; }
        public virtual ICollection<ServiceTypeSubQuality> ServiceTypeSubQualities { get; set; }
        public virtual ICollection<ServiceTypeSubQualityAlias> ServiceTypeSubQualityAliases { get; set; }
        public virtual ICollection<ServiceTypeSubstitution> ServiceTypeSubstitutionDestinationServiceTypes { get; set; }
        public virtual ICollection<ServiceTypeSubstitution> ServiceTypeSubstitutionSourceServiceTypeIdByReportNavigations { get; set; }
        public virtual ICollection<ServiceTypeSubstitution> ServiceTypeSubstitutionSourceServiceTypes { get; set; }
        public virtual ICollection<ServiceTypeSynonym> ServiceTypeSynonyms { get; set; }
        public virtual ICollection<UserServiceType> UserServiceTypes { get; set; }
    }
}
