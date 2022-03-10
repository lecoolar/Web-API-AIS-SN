using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class FasetItem
    {
        public FasetItem()
        {
            AccountCaseStatuses = new HashSet<AccountCaseStatus>();
            AccountDebtorsInfoForRia = new HashSet<AccountDebtorsInfoForRia>();
            AccountDocuments = new HashSet<AccountDocument>();
            AccountProperties = new HashSet<AccountProperty>();
            AccountService2s = new HashSet<AccountService2>();
            AccountServiceNormByUnits = new HashSet<AccountServiceNorm>();
            AccountServiceNormTypes = new HashSet<AccountServiceNormType>();
            AccountServiceNormUnits = new HashSet<AccountServiceNorm>();
            AccountServiceSubQualities = new HashSet<AccountServiceSubQuality>();
            AccountServiceSuspensions = new HashSet<AccountServiceSuspension>();
            AccountServiceTariffTypes = new HashSet<AccountServiceTariffType>();
            Accounts = new HashSet<Account>();
            Apartment1ObjectCategories = new HashSet<Apartment1>();
            Apartment1OkvedTypes = new HashSet<Apartment1>();
            ApartmentCanonicalTypes = new HashSet<ApartmentCanonicalType>();
            ApartmentCounterCommunalShareTypes = new HashSet<ApartmentCounter>();
            ApartmentCounterIndication1s = new HashSet<ApartmentCounterIndication1>();
            ApartmentCounterMaddleTypeNavigations = new HashSet<ApartmentCounter>();
            ApartmentCounterPlaceFactors = new HashSet<ApartmentCounterPlaceFactor>();
            ApartmentCounterPlaces = new HashSet<ApartmentCounter>();
            ApartmentCounterPlacesNavigation = new HashSet<ApartmentCounterPlace>();
            ApartmentCounterSeals = new HashSet<ApartmentCounterSeal>();
            ApartmentCounterStatusAskupeNavigations = new HashSet<ApartmentCounter>();
            ApartmentCounterTypeScaleCounters = new HashSet<ApartmentCounter>();
            ApartmentCounterTypes = new HashSet<ApartmentCounter>();
            ApartmentCounterVolumes = new HashSet<ApartmentCounterVolume>();
            ApartmentEquipments = new HashSet<ApartmentEquipment>();
            ApartmentHousekeepings = new HashSet<ApartmentHousekeeping>();
            ApartmentNotes = new HashSet<ApartmentNote>();
            ApartmentOwners = new HashSet<ApartmentOwner>();
            ApartmentProperty1s = new HashSet<ApartmentProperty1>();
            ApartmentRequestReasons = new HashSet<ApartmentRequest>();
            ApartmentRequestResults = new HashSet<ApartmentRequest>();
            ApartmentRequestTypes = new HashSet<ApartmentRequest>();
            ApartmentResidentBenefitProperties = new HashSet<ApartmentResidentBenefitProperty>();
            ApartmentResidentRelativeNavigations = new HashSet<ApartmentResident>();
            ApartmentResidentTypeResidentsNavigations = new HashSet<ApartmentResident>();
            ApartmentResidentVacations = new HashSet<ApartmentResidentVacation>();
            ApartmentTkoplatforms = new HashSet<ApartmentTkoplatform>();
            ApartmentTypes = new HashSet<ApartmentType>();
            AreaProperties = new HashSet<AreaProperty>();
            BankAccounts = new HashSet<BankAccount>();
            BankPaymentOrderBankTypes = new HashSet<BankPaymentOrder>();
            BankPaymentOrderStatuses = new HashSet<BankPaymentOrder>();
            BankPaymentOrdersRecordOtherBankPaymentAttributes = new HashSet<BankPaymentOrdersRecord>();
            BankPaymentOrdersRecordStatuses = new HashSet<BankPaymentOrdersRecord>();
            Benefit1s = new HashSet<Benefit1>();
            BenefitAreaBenefitAggregationTypes = new HashSet<BenefitArea>();
            BenefitAreaBenefitNormUseTypes = new HashSet<BenefitArea>();
            BenefitAreaExceptApartmentTypes = new HashSet<BenefitArea>();
            BenefitAreaFamilyFasets = new HashSet<BenefitArea>();
            BenefitNormsForElectrics = new HashSet<BenefitNormsForElectric>();
            BenefitNormsForGaExceptTypes = new HashSet<BenefitNormsForGa>();
            BenefitNormsForGaTypes = new HashSet<BenefitNormsForGa>();
            Budgets = new HashSet<Budget>();
            CalcAlgorithmDefaultTariffFasetNavigations = new HashSet<CalcAlgorithm>();
            CalcAlgorithmParamFasetItems = new HashSet<CalcAlgorithm>();
            CalcAlgorithmTypeFasetNavigations = new HashSet<CalcAlgorithm>();
            CalcAlgs = new HashSet<CalcAlg>();
            CalcServiceCountersByDay1s = new HashSet<CalcServiceCountersByDay1>();
            CanonicalServiceProperties = new HashSet<CanonicalServiceProperty>();
            CounterIndicationsFiles = new HashSet<CounterIndicationsFile>();
            DebtAccountInformStatuses = new HashSet<DebtAccountInform>();
            DebtAccountInformTypes = new HashSet<DebtAccountInform>();
            DebtActionCourtContents = new HashSet<DebtActionCourtContent>();
            DebtActionEventTypeEventNavigations = new HashSet<DebtActionEvent>();
            DebtActionEventTypeResultNavigations = new HashSet<DebtActionEvent>();
            DebtActionNoticeCauseNavigations = new HashSet<DebtActionNotice>();
            DebtActionNoticeNoticeResults = new HashSet<DebtActionNotice>();
            DebtActionNoticeReasonReturnNavigations = new HashSet<DebtActionNotice>();
            DebtActionNoticeSourcePaymentNavigations = new HashSet<DebtActionNotice>();
            DebtActionNoticeTypes = new HashSet<DebtActionNotice>();
            DebtActionStatuses = new HashSet<DebtAction>();
            DebtActionTypePirNavigations = new HashSet<DebtAction>();
            DebtAffairs = new HashSet<DebtAffair>();
            DocumentServices = new HashSet<DocumentService>();
            EventRegistrations = new HashSet<EventRegistration>();
            ExternalProcessingFileRecords = new HashSet<ExternalProcessingFileRecord>();
            FasetItemsHierarchyChildFasetItems = new HashSet<FasetItemsHierarchy>();
            FasetItemsHierarchyParentFasetItems = new HashSet<FasetItemsHierarchy>();
            GroupOperationSequences = new HashSet<GroupOperationSequence>();
            GroupOperationSubTypes = new HashSet<GroupOperation>();
            GroupOperationTypes = new HashSet<GroupOperation>();
            HouseBoroughs = new HashSet<House>();
            HouseCanonicalTypes = new HashSet<House>();
            HouseCanonicalTypesNavigation = new HashSet<HouseCanonicalType>();
            HouseCounter2StatusAskupeNavigations = new HashSet<HouseCounter2>();
            HouseCounter2TypeCounters = new HashSet<HouseCounter2>();
            HouseCounterHierarchies = new HashSet<HouseCounterHierarchy>();
            HouseCounterIndicationTypes = new HashSet<HouseCounterIndication>();
            HouseCounterIndicationValTypeNavigations = new HashSet<HouseCounterIndication>();
            HouseFireAlarmTypeNavigations = new HashSet<House>();
            HouseFormControlNavigations = new HashSet<House>();
            HouseFormControls = new HashSet<HouseFormControl>();
            HouseFoundationTypeNavigations = new HashSet<House>();
            HouseGvsTypeNavigations = new HashSet<House>();
            HouseGvssystemTypeNavigations = new HashSet<House>();
            HouseHeatingTypeNavigations = new HashSet<House>();
            HouseHvsTypeNavigations = new HashSet<House>();
            HouseLocalBroadcastingTypeNavigations = new HashSet<House>();
            HouseOverflowTypeNavigations = new HashSet<House>();
            HouseOverlapTypeNavigations = new HashSet<House>();
            HouseOwnershipTypeNavigations = new HashSet<House>();
            HouseProperties = new HashSet<HouseProperty>();
            HouseRoofTypeNavigations = new HashSet<House>();
            HouseServiceNormAppartmentTypeNavigations = new HashSet<HouseServiceNorm>();
            HouseServiceNormByUnits = new HashSet<HouseServiceNorm>();
            HouseServiceNormTypes = new HashSet<HouseServiceNormType>();
            HouseServiceNormUnits = new HashSet<HouseServiceNorm>();
            HouseServiceTariffTypes = new HashSet<HouseServiceTariffType>();
            HouseSewerTypeNavigations = new HashSet<House>();
            HouseStoveTypeNavigations = new HashSet<House>();
            HouseSudNavigations = new HashSet<House>();
            HouseTvenquipmentTypeNavigations = new HashSet<House>();
            HouseTypeNavigations = new HashSet<House>();
            HouseUtilizationTypeNavigations = new HashSet<House>();
            HouseWallTypeNavigations = new HashSet<House>();
            InterfaceDynamicParameters = new HashSet<InterfaceDynamicParameter>();
            JnCommissions = new HashSet<JnCommission>();
            KbkserviceTypeFasetItem161s = new HashSet<KbkserviceType>();
            KbkserviceTypeFasetItem162s = new HashSet<KbkserviceType>();
            KbkserviceTypeFasetItem163s = new HashSet<KbkserviceType>();
            NonresidentialApartmentProperties = new HashSet<NonresidentialApartmentProperty>();
            NormsForElectrics = new HashSet<NormsForElectric>();
            OrgDocuments = new HashSet<OrgDocument>();
            OrgDocumentsEventLogs = new HashSet<OrgDocumentsEventLog>();
            Organization1BudgetTypeNavigations = new HashSet<Organization1>();
            Organization1ConsumersTypeNavigations = new HashSet<Organization1>();
            Organization1FkkoTypeNavigations = new HashSet<Organization1>();
            Organization1OkvedTypeNavigations = new HashSet<Organization1>();
            Organization1OrganizationTypeNavigations = new HashSet<Organization1>();
            Organization1PurchaseMethodNavigations = new HashSet<Organization1>();
            Organization1TkoTypeNavigations = new HashSet<Organization1>();
            OrganizationLicenses = new HashSet<OrganizationLicense>();
            OrganizationMaterials = new HashSet<OrganizationMaterial>();
            OrganizationProperties = new HashSet<OrganizationProperty>();
            OrganizationWages = new HashSet<OrganizationWage>();
            OrganizationWasteClassificators = new HashSet<OrganizationWasteClassificator>();
            PaymentSystemAgents = new HashSet<PaymentSystemAgent>();
            PaymentSystems = new HashSet<PaymentSystem>();
            PersonBenefitDocuments = new HashSet<PersonBenefitDocument>();
            PersonByOrganizationSexNavigations = new HashSet<PersonByOrganization>();
            PersonByOrganizationTypeDocNavigations = new HashSet<PersonByOrganization>();
            PersonFamilies = new HashSet<PersonFamily>();
            PersonSexNavigations = new HashSet<Person>();
            PersonTypeDocNavigations = new HashSet<Person>();
            ReesterReasonReturns = new HashSet<Reester>();
            ReesterRecordOtherPaymentAttributes = new HashSet<ReesterRecord>();
            ReesterRecordReesterRecordTypeFasets = new HashSet<ReesterRecord>();
            ReesterRecordStatuses = new HashSet<ReesterRecord>();
            ReesterReeTypes = new HashSet<Reester>();
            ReesterStatuses = new HashSet<Reester>();
            Request1s = new HashSet<Request1>();
            RequestGates = new HashSet<RequestGate>();
            Service1s = new HashSet<Service1>();
            ServiceNormByUnits = new HashSet<ServiceNorm>();
            ServiceNormTypes = new HashSet<ServiceNormType>();
            ServiceNormUnits = new HashSet<ServiceNorm>();
            ServiceTariffTypes = new HashSet<ServiceTariffType>();
            ServiceTypeContexts = new HashSet<ServiceTypeContext>();
            ServiceTypeGroupConditionRuleNormRates = new HashSet<ServiceTypeGroupCondition>();
            ServiceTypeGroupConditionRuleRates = new HashSet<ServiceTypeGroupCondition>();
            ServiceTypeGroupConditionRuleResurces = new HashSet<ServiceTypeGroupCondition>();
            ServiceTypeGroupPermits = new HashSet<ServiceTypeGroupPermit>();
            ServiceTypeGroups = new HashSet<ServiceTypeGroup>();
            ServiceTypeSubQualities = new HashSet<ServiceTypeSubQuality>();
            ServiceTypeTypes = new HashSet<ServiceType>();
            ServiceTypeUnits = new HashSet<ServiceType>();
            Settings = new HashSet<Setting>();
            TemperatureInternals = new HashSet<TemperatureInternal>();
            UserPaymentAgentTypes = new HashSet<User>();
            UserPositions = new HashSet<User>();
            UserUserJobs = new HashSet<User>();
        }

        public int Id { get; set; }
        public short FasetId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public virtual Faset Faset { get; set; }
        public virtual ICollection<AccountCaseStatus> AccountCaseStatuses { get; set; }
        public virtual ICollection<AccountDebtorsInfoForRia> AccountDebtorsInfoForRia { get; set; }
        public virtual ICollection<AccountDocument> AccountDocuments { get; set; }
        public virtual ICollection<AccountProperty> AccountProperties { get; set; }
        public virtual ICollection<AccountService2> AccountService2s { get; set; }
        public virtual ICollection<AccountServiceNorm> AccountServiceNormByUnits { get; set; }
        public virtual ICollection<AccountServiceNormType> AccountServiceNormTypes { get; set; }
        public virtual ICollection<AccountServiceNorm> AccountServiceNormUnits { get; set; }
        public virtual ICollection<AccountServiceSubQuality> AccountServiceSubQualities { get; set; }
        public virtual ICollection<AccountServiceSuspension> AccountServiceSuspensions { get; set; }
        public virtual ICollection<AccountServiceTariffType> AccountServiceTariffTypes { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Apartment1> Apartment1ObjectCategories { get; set; }
        public virtual ICollection<Apartment1> Apartment1OkvedTypes { get; set; }
        public virtual ICollection<ApartmentCanonicalType> ApartmentCanonicalTypes { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounterCommunalShareTypes { get; set; }
        public virtual ICollection<ApartmentCounterIndication1> ApartmentCounterIndication1s { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounterMaddleTypeNavigations { get; set; }
        public virtual ICollection<ApartmentCounterPlaceFactor> ApartmentCounterPlaceFactors { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounterPlaces { get; set; }
        public virtual ICollection<ApartmentCounterPlace> ApartmentCounterPlacesNavigation { get; set; }
        public virtual ICollection<ApartmentCounterSeal> ApartmentCounterSeals { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounterStatusAskupeNavigations { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounterTypeScaleCounters { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounterTypes { get; set; }
        public virtual ICollection<ApartmentCounterVolume> ApartmentCounterVolumes { get; set; }
        public virtual ICollection<ApartmentEquipment> ApartmentEquipments { get; set; }
        public virtual ICollection<ApartmentHousekeeping> ApartmentHousekeepings { get; set; }
        public virtual ICollection<ApartmentNote> ApartmentNotes { get; set; }
        public virtual ICollection<ApartmentOwner> ApartmentOwners { get; set; }
        public virtual ICollection<ApartmentProperty1> ApartmentProperty1s { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequestReasons { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequestResults { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequestTypes { get; set; }
        public virtual ICollection<ApartmentResidentBenefitProperty> ApartmentResidentBenefitProperties { get; set; }
        public virtual ICollection<ApartmentResident> ApartmentResidentRelativeNavigations { get; set; }
        public virtual ICollection<ApartmentResident> ApartmentResidentTypeResidentsNavigations { get; set; }
        public virtual ICollection<ApartmentResidentVacation> ApartmentResidentVacations { get; set; }
        public virtual ICollection<ApartmentTkoplatform> ApartmentTkoplatforms { get; set; }
        public virtual ICollection<ApartmentType> ApartmentTypes { get; set; }
        public virtual ICollection<AreaProperty> AreaProperties { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<BankPaymentOrder> BankPaymentOrderBankTypes { get; set; }
        public virtual ICollection<BankPaymentOrder> BankPaymentOrderStatuses { get; set; }
        public virtual ICollection<BankPaymentOrdersRecord> BankPaymentOrdersRecordOtherBankPaymentAttributes { get; set; }
        public virtual ICollection<BankPaymentOrdersRecord> BankPaymentOrdersRecordStatuses { get; set; }
        public virtual ICollection<Benefit1> Benefit1s { get; set; }
        public virtual ICollection<BenefitArea> BenefitAreaBenefitAggregationTypes { get; set; }
        public virtual ICollection<BenefitArea> BenefitAreaBenefitNormUseTypes { get; set; }
        public virtual ICollection<BenefitArea> BenefitAreaExceptApartmentTypes { get; set; }
        public virtual ICollection<BenefitArea> BenefitAreaFamilyFasets { get; set; }
        public virtual ICollection<BenefitNormsForElectric> BenefitNormsForElectrics { get; set; }
        public virtual ICollection<BenefitNormsForGa> BenefitNormsForGaExceptTypes { get; set; }
        public virtual ICollection<BenefitNormsForGa> BenefitNormsForGaTypes { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<CalcAlgorithm> CalcAlgorithmDefaultTariffFasetNavigations { get; set; }
        public virtual ICollection<CalcAlgorithm> CalcAlgorithmParamFasetItems { get; set; }
        public virtual ICollection<CalcAlgorithm> CalcAlgorithmTypeFasetNavigations { get; set; }
        public virtual ICollection<CalcAlg> CalcAlgs { get; set; }
        public virtual ICollection<CalcServiceCountersByDay1> CalcServiceCountersByDay1s { get; set; }
        public virtual ICollection<CanonicalServiceProperty> CanonicalServiceProperties { get; set; }
        public virtual ICollection<CounterIndicationsFile> CounterIndicationsFiles { get; set; }
        public virtual ICollection<DebtAccountInform> DebtAccountInformStatuses { get; set; }
        public virtual ICollection<DebtAccountInform> DebtAccountInformTypes { get; set; }
        public virtual ICollection<DebtActionCourtContent> DebtActionCourtContents { get; set; }
        public virtual ICollection<DebtActionEvent> DebtActionEventTypeEventNavigations { get; set; }
        public virtual ICollection<DebtActionEvent> DebtActionEventTypeResultNavigations { get; set; }
        public virtual ICollection<DebtActionNotice> DebtActionNoticeCauseNavigations { get; set; }
        public virtual ICollection<DebtActionNotice> DebtActionNoticeNoticeResults { get; set; }
        public virtual ICollection<DebtActionNotice> DebtActionNoticeReasonReturnNavigations { get; set; }
        public virtual ICollection<DebtActionNotice> DebtActionNoticeSourcePaymentNavigations { get; set; }
        public virtual ICollection<DebtActionNotice> DebtActionNoticeTypes { get; set; }
        public virtual ICollection<DebtAction> DebtActionStatuses { get; set; }
        public virtual ICollection<DebtAction> DebtActionTypePirNavigations { get; set; }
        public virtual ICollection<DebtAffair> DebtAffairs { get; set; }
        public virtual ICollection<DocumentService> DocumentServices { get; set; }
        public virtual ICollection<EventRegistration> EventRegistrations { get; set; }
        public virtual ICollection<ExternalProcessingFileRecord> ExternalProcessingFileRecords { get; set; }
        public virtual ICollection<FasetItemsHierarchy> FasetItemsHierarchyChildFasetItems { get; set; }
        public virtual ICollection<FasetItemsHierarchy> FasetItemsHierarchyParentFasetItems { get; set; }
        public virtual ICollection<GroupOperationSequence> GroupOperationSequences { get; set; }
        public virtual ICollection<GroupOperation> GroupOperationSubTypes { get; set; }
        public virtual ICollection<GroupOperation> GroupOperationTypes { get; set; }
        public virtual ICollection<House> HouseBoroughs { get; set; }
        public virtual ICollection<House> HouseCanonicalTypes { get; set; }
        public virtual ICollection<HouseCanonicalType> HouseCanonicalTypesNavigation { get; set; }
        public virtual ICollection<HouseCounter2> HouseCounter2StatusAskupeNavigations { get; set; }
        public virtual ICollection<HouseCounter2> HouseCounter2TypeCounters { get; set; }
        public virtual ICollection<HouseCounterHierarchy> HouseCounterHierarchies { get; set; }
        public virtual ICollection<HouseCounterIndication> HouseCounterIndicationTypes { get; set; }
        public virtual ICollection<HouseCounterIndication> HouseCounterIndicationValTypeNavigations { get; set; }
        public virtual ICollection<House> HouseFireAlarmTypeNavigations { get; set; }
        public virtual ICollection<House> HouseFormControlNavigations { get; set; }
        public virtual ICollection<HouseFormControl> HouseFormControls { get; set; }
        public virtual ICollection<House> HouseFoundationTypeNavigations { get; set; }
        public virtual ICollection<House> HouseGvsTypeNavigations { get; set; }
        public virtual ICollection<House> HouseGvssystemTypeNavigations { get; set; }
        public virtual ICollection<House> HouseHeatingTypeNavigations { get; set; }
        public virtual ICollection<House> HouseHvsTypeNavigations { get; set; }
        public virtual ICollection<House> HouseLocalBroadcastingTypeNavigations { get; set; }
        public virtual ICollection<House> HouseOverflowTypeNavigations { get; set; }
        public virtual ICollection<House> HouseOverlapTypeNavigations { get; set; }
        public virtual ICollection<House> HouseOwnershipTypeNavigations { get; set; }
        public virtual ICollection<HouseProperty> HouseProperties { get; set; }
        public virtual ICollection<House> HouseRoofTypeNavigations { get; set; }
        public virtual ICollection<HouseServiceNorm> HouseServiceNormAppartmentTypeNavigations { get; set; }
        public virtual ICollection<HouseServiceNorm> HouseServiceNormByUnits { get; set; }
        public virtual ICollection<HouseServiceNormType> HouseServiceNormTypes { get; set; }
        public virtual ICollection<HouseServiceNorm> HouseServiceNormUnits { get; set; }
        public virtual ICollection<HouseServiceTariffType> HouseServiceTariffTypes { get; set; }
        public virtual ICollection<House> HouseSewerTypeNavigations { get; set; }
        public virtual ICollection<House> HouseStoveTypeNavigations { get; set; }
        public virtual ICollection<House> HouseSudNavigations { get; set; }
        public virtual ICollection<House> HouseTvenquipmentTypeNavigations { get; set; }
        public virtual ICollection<House> HouseTypeNavigations { get; set; }
        public virtual ICollection<House> HouseUtilizationTypeNavigations { get; set; }
        public virtual ICollection<House> HouseWallTypeNavigations { get; set; }
        public virtual ICollection<InterfaceDynamicParameter> InterfaceDynamicParameters { get; set; }
        public virtual ICollection<JnCommission> JnCommissions { get; set; }
        public virtual ICollection<KbkserviceType> KbkserviceTypeFasetItem161s { get; set; }
        public virtual ICollection<KbkserviceType> KbkserviceTypeFasetItem162s { get; set; }
        public virtual ICollection<KbkserviceType> KbkserviceTypeFasetItem163s { get; set; }
        public virtual ICollection<NonresidentialApartmentProperty> NonresidentialApartmentProperties { get; set; }
        public virtual ICollection<NormsForElectric> NormsForElectrics { get; set; }
        public virtual ICollection<OrgDocument> OrgDocuments { get; set; }
        public virtual ICollection<OrgDocumentsEventLog> OrgDocumentsEventLogs { get; set; }
        public virtual ICollection<Organization1> Organization1BudgetTypeNavigations { get; set; }
        public virtual ICollection<Organization1> Organization1ConsumersTypeNavigations { get; set; }
        public virtual ICollection<Organization1> Organization1FkkoTypeNavigations { get; set; }
        public virtual ICollection<Organization1> Organization1OkvedTypeNavigations { get; set; }
        public virtual ICollection<Organization1> Organization1OrganizationTypeNavigations { get; set; }
        public virtual ICollection<Organization1> Organization1PurchaseMethodNavigations { get; set; }
        public virtual ICollection<Organization1> Organization1TkoTypeNavigations { get; set; }
        public virtual ICollection<OrganizationLicense> OrganizationLicenses { get; set; }
        public virtual ICollection<OrganizationMaterial> OrganizationMaterials { get; set; }
        public virtual ICollection<OrganizationProperty> OrganizationProperties { get; set; }
        public virtual ICollection<OrganizationWage> OrganizationWages { get; set; }
        public virtual ICollection<OrganizationWasteClassificator> OrganizationWasteClassificators { get; set; }
        public virtual ICollection<PaymentSystemAgent> PaymentSystemAgents { get; set; }
        public virtual ICollection<PaymentSystem> PaymentSystems { get; set; }
        public virtual ICollection<PersonBenefitDocument> PersonBenefitDocuments { get; set; }
        public virtual ICollection<PersonByOrganization> PersonByOrganizationSexNavigations { get; set; }
        public virtual ICollection<PersonByOrganization> PersonByOrganizationTypeDocNavigations { get; set; }
        public virtual ICollection<PersonFamily> PersonFamilies { get; set; }
        public virtual ICollection<Person> PersonSexNavigations { get; set; }
        public virtual ICollection<Person> PersonTypeDocNavigations { get; set; }
        public virtual ICollection<Reester> ReesterReasonReturns { get; set; }
        public virtual ICollection<ReesterRecord> ReesterRecordOtherPaymentAttributes { get; set; }
        public virtual ICollection<ReesterRecord> ReesterRecordReesterRecordTypeFasets { get; set; }
        public virtual ICollection<ReesterRecord> ReesterRecordStatuses { get; set; }
        public virtual ICollection<Reester> ReesterReeTypes { get; set; }
        public virtual ICollection<Reester> ReesterStatuses { get; set; }
        public virtual ICollection<Request1> Request1s { get; set; }
        public virtual ICollection<RequestGate> RequestGates { get; set; }
        public virtual ICollection<Service1> Service1s { get; set; }
        public virtual ICollection<ServiceNorm> ServiceNormByUnits { get; set; }
        public virtual ICollection<ServiceNormType> ServiceNormTypes { get; set; }
        public virtual ICollection<ServiceNorm> ServiceNormUnits { get; set; }
        public virtual ICollection<ServiceTariffType> ServiceTariffTypes { get; set; }
        public virtual ICollection<ServiceTypeContext> ServiceTypeContexts { get; set; }
        public virtual ICollection<ServiceTypeGroupCondition> ServiceTypeGroupConditionRuleNormRates { get; set; }
        public virtual ICollection<ServiceTypeGroupCondition> ServiceTypeGroupConditionRuleRates { get; set; }
        public virtual ICollection<ServiceTypeGroupCondition> ServiceTypeGroupConditionRuleResurces { get; set; }
        public virtual ICollection<ServiceTypeGroupPermit> ServiceTypeGroupPermits { get; set; }
        public virtual ICollection<ServiceTypeGroup> ServiceTypeGroups { get; set; }
        public virtual ICollection<ServiceTypeSubQuality> ServiceTypeSubQualities { get; set; }
        public virtual ICollection<ServiceType> ServiceTypeTypes { get; set; }
        public virtual ICollection<ServiceType> ServiceTypeUnits { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
        public virtual ICollection<TemperatureInternal> TemperatureInternals { get; set; }
        public virtual ICollection<User> UserPaymentAgentTypes { get; set; }
        public virtual ICollection<User> UserPositions { get; set; }
        public virtual ICollection<User> UserUserJobs { get; set; }
    }
}
