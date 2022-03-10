using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Organization1
    {
        public Organization1()
        {
            AccountCashlessProperties = new HashSet<AccountCashlessProperty>();
            AccountDebtorsInfoForRia = new HashSet<AccountDebtorsInfoForRia>();
            AccountHouseHolders = new HashSet<AccountHouseHolder>();
            AccountProviderProviders = new HashSet<AccountProvider>();
            AccountProviderSubProviders = new HashSet<AccountProvider>();
            AccountService4s = new HashSet<AccountService4>();
            ApartmentCounterBetweenCheckIntervals = new HashSet<ApartmentCounterBetweenCheckInterval>();
            ApartmentHouseHolder1s = new HashSet<ApartmentHouseHolder1>();
            ApartmentTerritorialSubdivisions = new HashSet<ApartmentTerritorialSubdivision>();
            AreaOrganizations = new HashSet<AreaOrganization>();
            BankAccountProviders = new HashSet<BankAccountProvider>();
            BenefitServiceTypes = new HashSet<BenefitServiceType>();
            Budgets = new HashSet<Budget>();
            DebtAccountInforms = new HashSet<DebtAccountInform>();
            DebtDocuments = new HashSet<DebtDocument>();
            DebtorCards = new HashSet<DebtorCard>();
            DistributionOfOrganizationsPriorityAccountHouseHolders = new HashSet<DistributionOfOrganizationsPriority>();
            DistributionOfOrganizationsPriorityServiceOrganizations = new HashSet<DistributionOfOrganizationsPriority>();
            DocumentServiceOrgs = new HashSet<DocumentServiceOrg>();
            DocumentServices = new HashSet<DocumentService>();
            GroupOperations = new HashSet<GroupOperation>();
            HouseCounterBetweenCheckIntervals = new HashSet<HouseCounterBetweenCheckInterval>();
            HouseGeneralContractors = new HashSet<HouseGeneralContractor>();
            HouseHouseHolders = new HashSet<HouseHouseHolder>();
            HouseKapRemMkdbankAccountOwnerOrgs = new HashSet<House>();
            HouseOuterInformations = new HashSet<HouseOuterInformation>();
            HouseResourceProviders = new HashSet<HouseResourceProvider>();
            HouseServiceProviderServiceHouseHolders = new HashSet<HouseServiceProvider>();
            HouseServiceProviderServiceProviders = new HashSet<HouseServiceProvider>();
            HouseServiceRestrictionsOnUnloadings = new HashSet<HouseServiceRestrictionsOnUnloading>();
            HouseTerritorialBailiffDepartments = new HashSet<House>();
            HouseTreatyCommitments = new HashSet<HouseTreatyCommitment>();
            InverseParent = new HashSet<Organization1>();
            JnBankPaymentOrderOutputs = new HashSet<JnBankPaymentOrderOutput>();
            JnCommissions = new HashSet<JnCommission>();
            LocalAddressSynonyms = new HashSet<LocalAddressSynonym>();
            OrgDocuments = new HashSet<OrgDocument>();
            OrganizationCommissions = new HashSet<OrganizationCommission>();
            OrganizationGroupContents = new HashSet<OrganizationGroupContent>();
            OrganizationLicenses = new HashSet<OrganizationLicense>();
            OrganizationMaterials = new HashSet<OrganizationMaterial>();
            OrganizationPenaltiesSuspensions = new HashSet<OrganizationPenaltiesSuspension>();
            OrganizationProperties = new HashSet<OrganizationProperty>();
            OrganizationWages = new HashSet<OrganizationWage>();
            OrganizationWasteClassificators = new HashSet<OrganizationWasteClassificator>();
            Orgs = new HashSet<Org>();
            Owners = new HashSet<Owner>();
            PaymentOrder1s = new HashSet<PaymentOrder1>();
            PaymentSystemAgentCashlessOrgs = new HashSet<PaymentSystemAgent>();
            PaymentSystemAgentOrganizations = new HashSet<PaymentSystemAgent>();
            Payments = new HashSet<Payment>();
            People = new HashSet<Person>();
            PersonBenefitDocuments = new HashSet<PersonBenefitDocument>();
            PersonByOrganizationOrgBenefits = new HashSet<PersonByOrganization>();
            PersonByOrganizationOrgs = new HashSet<PersonByOrganization>();
            ReesterHouseHolders = new HashSet<Reester>();
            ReesterOrganizationNavigations = new HashSet<Reester>();
            Remittees = new HashSet<Remittee>();
            Service1ExecutorGis = new HashSet<Service1>();
            Service1FinancialCenters = new HashSet<Service1>();
            Service1GeneralContractors = new HashSet<Service1>();
            Service1HouseHolders = new HashSet<Service1>();
            Service1Providers = new HashSet<Service1>();
            Service1ResourceProviders = new HashSet<Service1>();
            ServiceSplitBalances = new HashSet<ServiceSplitBalance>();
            ServiceSplitDocuments = new HashSet<ServiceSplitDocument>();
            ServiceSplitJns = new HashSet<ServiceSplitJn>();
            ServiceSplitLinks = new HashSet<ServiceSplitLink>();
            ServiceSplitTransfers = new HashSet<ServiceSplitTransfer>();
            ServiceTypeSynonyms = new HashSet<ServiceTypeSynonym>();
            Treaties = new HashSet<Treaty>();
            UserOrganizations = new HashSet<UserOrganization>();
            UserUnitOrganizations = new HashSet<UserUnitOrganization>();
            Users = new HashSet<User>();
        }

        public long Id { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public long? ParentId { get; set; }
        public bool IsServiceProvider { get; set; }
        public bool IsHouseHolder { get; set; }
        public bool IsCashlessTransferrer { get; set; }
        public bool IsBenefitTransferrer { get; set; }
        public bool IsFlatOwner { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public string Info { get; set; }
        public string AddrInfo { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Manager { get; set; }
        public string ManagerPosition { get; set; }
        public string AddrName { get; set; }
        public bool IsBankrupt { get; set; }
        public string TelephoneEmergencyDispatchService { get; set; }
        public bool IsPaymentAgent { get; set; }
        public bool IsResourceProvider { get; set; }
        public bool IsContractEnded { get; set; }
        public string ModeWork { get; set; }
        public bool? IsBankPaymentAgent { get; set; }
        public string ChiefAccountant { get; set; }
        public int? DistributionPayment { get; set; }
        public bool? IsPaymentUseNotice { get; set; }
        public bool? IsPaymentUseNegativeSumm { get; set; }
        public bool IsFinancialCenter { get; set; }
        public string NoticeInformation { get; set; }
        public bool NoticeInformationWithAddressesInfo { get; set; }
        public bool NoticeInformationOnlyAddressesInfo { get; set; }
        public DateTime? FromDateOfAccrualPenalties { get; set; }
        public string ReportsSignature { get; set; }
        public string AddrInternetInfo { get; set; }
        public string Kbk { get; set; }
        public string Oktmo { get; set; }
        public bool IsUnitOrganization { get; set; }
        public bool IsGeneralContractor { get; set; }
        public int? OrgLegalForm { get; set; }
        public int? OrgType { get; set; }
        public DateTime? OrgRegistrationDate { get; set; }
        public string KodObj { get; set; }
        public string Ogrnip { get; set; }
        public long? JuridicAdrId { get; set; }
        public long? FactAdrId { get; set; }
        public long? MailAdrId { get; set; }
        public int? OkvedType { get; set; }
        public int? BudgetType { get; set; }
        public int? FkkoType { get; set; }
        public int? OrganizationType { get; set; }
        public int? ConsumersType { get; set; }
        public int? PurchaseMethod { get; set; }
        public int? TkoType { get; set; }
        public long? DepartmentId { get; set; }
        public string Email { get; set; }
        public long? OrpKey { get; set; }
        public bool IsTerritorialManage { get; set; }

        public virtual FasetItem BudgetTypeNavigation { get; set; }
        public virtual FasetItem ConsumersTypeNavigation { get; set; }
        public virtual LocalAddress FactAdr { get; set; }
        public virtual FasetItem FkkoTypeNavigation { get; set; }
        public virtual LocalAddress JuridicAdr { get; set; }
        public virtual LocalAddress MailAdr { get; set; }
        public virtual FasetItem OkvedTypeNavigation { get; set; }
        public virtual FasetItem OrganizationTypeNavigation { get; set; }
        public virtual Organization1 Parent { get; set; }
        public virtual FasetItem PurchaseMethodNavigation { get; set; }
        public virtual FasetItem TkoTypeNavigation { get; set; }
        public virtual OrganizationInfo OrganizationInfo { get; set; }
        public virtual ICollection<AccountCashlessProperty> AccountCashlessProperties { get; set; }
        public virtual ICollection<AccountDebtorsInfoForRia> AccountDebtorsInfoForRia { get; set; }
        public virtual ICollection<AccountHouseHolder> AccountHouseHolders { get; set; }
        public virtual ICollection<AccountProvider> AccountProviderProviders { get; set; }
        public virtual ICollection<AccountProvider> AccountProviderSubProviders { get; set; }
        public virtual ICollection<AccountService4> AccountService4s { get; set; }
        public virtual ICollection<ApartmentCounterBetweenCheckInterval> ApartmentCounterBetweenCheckIntervals { get; set; }
        public virtual ICollection<ApartmentHouseHolder1> ApartmentHouseHolder1s { get; set; }
        public virtual ICollection<ApartmentTerritorialSubdivision> ApartmentTerritorialSubdivisions { get; set; }
        public virtual ICollection<AreaOrganization> AreaOrganizations { get; set; }
        public virtual ICollection<BankAccountProvider> BankAccountProviders { get; set; }
        public virtual ICollection<BenefitServiceType> BenefitServiceTypes { get; set; }
        public virtual ICollection<Budget> Budgets { get; set; }
        public virtual ICollection<DebtAccountInform> DebtAccountInforms { get; set; }
        public virtual ICollection<DebtDocument> DebtDocuments { get; set; }
        public virtual ICollection<DebtorCard> DebtorCards { get; set; }
        public virtual ICollection<DistributionOfOrganizationsPriority> DistributionOfOrganizationsPriorityAccountHouseHolders { get; set; }
        public virtual ICollection<DistributionOfOrganizationsPriority> DistributionOfOrganizationsPriorityServiceOrganizations { get; set; }
        public virtual ICollection<DocumentServiceOrg> DocumentServiceOrgs { get; set; }
        public virtual ICollection<DocumentService> DocumentServices { get; set; }
        public virtual ICollection<GroupOperation> GroupOperations { get; set; }
        public virtual ICollection<HouseCounterBetweenCheckInterval> HouseCounterBetweenCheckIntervals { get; set; }
        public virtual ICollection<HouseGeneralContractor> HouseGeneralContractors { get; set; }
        public virtual ICollection<HouseHouseHolder> HouseHouseHolders { get; set; }
        public virtual ICollection<House> HouseKapRemMkdbankAccountOwnerOrgs { get; set; }
        public virtual ICollection<HouseOuterInformation> HouseOuterInformations { get; set; }
        public virtual ICollection<HouseResourceProvider> HouseResourceProviders { get; set; }
        public virtual ICollection<HouseServiceProvider> HouseServiceProviderServiceHouseHolders { get; set; }
        public virtual ICollection<HouseServiceProvider> HouseServiceProviderServiceProviders { get; set; }
        public virtual ICollection<HouseServiceRestrictionsOnUnloading> HouseServiceRestrictionsOnUnloadings { get; set; }
        public virtual ICollection<House> HouseTerritorialBailiffDepartments { get; set; }
        public virtual ICollection<HouseTreatyCommitment> HouseTreatyCommitments { get; set; }
        public virtual ICollection<Organization1> InverseParent { get; set; }
        public virtual ICollection<JnBankPaymentOrderOutput> JnBankPaymentOrderOutputs { get; set; }
        public virtual ICollection<JnCommission> JnCommissions { get; set; }
        public virtual ICollection<LocalAddressSynonym> LocalAddressSynonyms { get; set; }
        public virtual ICollection<OrgDocument> OrgDocuments { get; set; }
        public virtual ICollection<OrganizationCommission> OrganizationCommissions { get; set; }
        public virtual ICollection<OrganizationGroupContent> OrganizationGroupContents { get; set; }
        public virtual ICollection<OrganizationLicense> OrganizationLicenses { get; set; }
        public virtual ICollection<OrganizationMaterial> OrganizationMaterials { get; set; }
        public virtual ICollection<OrganizationPenaltiesSuspension> OrganizationPenaltiesSuspensions { get; set; }
        public virtual ICollection<OrganizationProperty> OrganizationProperties { get; set; }
        public virtual ICollection<OrganizationWage> OrganizationWages { get; set; }
        public virtual ICollection<OrganizationWasteClassificator> OrganizationWasteClassificators { get; set; }
        public virtual ICollection<Org> Orgs { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
        public virtual ICollection<PaymentOrder1> PaymentOrder1s { get; set; }
        public virtual ICollection<PaymentSystemAgent> PaymentSystemAgentCashlessOrgs { get; set; }
        public virtual ICollection<PaymentSystemAgent> PaymentSystemAgentOrganizations { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<PersonBenefitDocument> PersonBenefitDocuments { get; set; }
        public virtual ICollection<PersonByOrganization> PersonByOrganizationOrgBenefits { get; set; }
        public virtual ICollection<PersonByOrganization> PersonByOrganizationOrgs { get; set; }
        public virtual ICollection<Reester> ReesterHouseHolders { get; set; }
        public virtual ICollection<Reester> ReesterOrganizationNavigations { get; set; }
        public virtual ICollection<Remittee> Remittees { get; set; }
        public virtual ICollection<Service1> Service1ExecutorGis { get; set; }
        public virtual ICollection<Service1> Service1FinancialCenters { get; set; }
        public virtual ICollection<Service1> Service1GeneralContractors { get; set; }
        public virtual ICollection<Service1> Service1HouseHolders { get; set; }
        public virtual ICollection<Service1> Service1Providers { get; set; }
        public virtual ICollection<Service1> Service1ResourceProviders { get; set; }
        public virtual ICollection<ServiceSplitBalance> ServiceSplitBalances { get; set; }
        public virtual ICollection<ServiceSplitDocument> ServiceSplitDocuments { get; set; }
        public virtual ICollection<ServiceSplitJn> ServiceSplitJns { get; set; }
        public virtual ICollection<ServiceSplitLink> ServiceSplitLinks { get; set; }
        public virtual ICollection<ServiceSplitTransfer> ServiceSplitTransfers { get; set; }
        public virtual ICollection<ServiceTypeSynonym> ServiceTypeSynonyms { get; set; }
        public virtual ICollection<Treaty> Treaties { get; set; }
        public virtual ICollection<UserOrganization> UserOrganizations { get; set; }
        public virtual ICollection<UserUnitOrganization> UserUnitOrganizations { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
