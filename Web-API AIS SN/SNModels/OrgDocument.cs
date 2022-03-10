using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrgDocument
    {
        public OrgDocument()
        {
            AccountDocuments = new HashSet<AccountDocument>();
            AccountPenaltyRemissions = new HashSet<AccountPenaltyRemission>();
            AccountService4CloseDocs = new HashSet<AccountService4>();
            AccountService4OpenDocs = new HashSet<AccountService4>();
            AccountServiceDocuments = new HashSet<AccountServiceDocument>();
            AccountServiceNorms = new HashSet<AccountServiceNorm>();
            AccountServicePenaltyRemissions = new HashSet<AccountServicePenaltyRemission>();
            AccountServiceTariffs = new HashSet<AccountServiceTariff>();
            Apartment1s = new HashSet<Apartment1>();
            ApartmentCounterBetweenCheckIntervals = new HashSet<ApartmentCounterBetweenCheckInterval>();
            ApartmentNotes = new HashSet<ApartmentNote>();
            ApartmentOwners = new HashSet<ApartmentOwner>();
            DebtDocuments = new HashSet<DebtDocument>();
            GroupOperations = new HashSet<GroupOperation>();
            HouseCounterIndications = new HashSet<HouseCounterIndication>();
            HouseProperties = new HashSet<HouseProperty>();
            HouseServiceNorms = new HashSet<HouseServiceNorm>();
            HouseServiceRestrictionsOnUnloadings = new HashSet<HouseServiceRestrictionsOnUnloading>();
            HouseServiceTariffs = new HashSet<HouseServiceTariff>();
            OrgDocumentTypeDocs = new HashSet<OrgDocumentTypeDoc>();
            OrgDocumentsEventLogs = new HashSet<OrgDocumentsEventLog>();
            OrganizationPenaltiesSuspensions = new HashSet<OrganizationPenaltiesSuspension>();
            Remittees = new HashSet<Remittee>();
            Service1s = new HashSet<Service1>();
            ServiceCommissions = new HashSet<ServiceCommission>();
            ServiceNorms = new HashSet<ServiceNorm>();
            ServicePenalties = new HashSet<ServicePenalty>();
            ServiceSplitBalances = new HashSet<ServiceSplitBalance>();
            ServiceSplitDocuments = new HashSet<ServiceSplitDocument>();
            ServiceSplitJns = new HashSet<ServiceSplitJn>();
            ServiceSplitLinks = new HashSet<ServiceSplitLink>();
            ServiceSplitPaymentPercents = new HashSet<ServiceSplitPaymentPercent>();
            ServiceSplitPercents = new HashSet<ServiceSplitPercent>();
            ServiceSplitTransfers = new HashSet<ServiceSplitTransfer>();
            ServiceTariffs = new HashSet<ServiceTariff>();
            ServiceTypeSubQualities = new HashSet<ServiceTypeSubQuality>();
            StreamFiles = new HashSet<StreamFile>();
        }

        public long Id { get; set; }
        public int TypeId { get; set; }
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public string Comment { get; set; }
        public long OrgId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string KodObj { get; set; }
        public decimal? Summ { get; set; }
        public decimal? Volume { get; set; }
        public bool? PaymentDocuments { get; set; }
        public bool? PaymentRequirements { get; set; }
        public bool? ConnectionService { get; set; }
        public DateTime? FromDateEdo { get; set; }
        public DateTime? ToDateEdo { get; set; }
        public int? OkvedType { get; set; }
        public string DeliveryOrganization { get; set; }
        public long? BillingAddress { get; set; }
        public bool? PDagentDecryption { get; set; }
        public bool? AgreementEdo { get; set; }
        public DateTime? DbFromDateLk { get; set; }
        public DateTime? DbToDateLk { get; set; }
        public long? SignerId { get; set; }
        public long? CuratorId { get; set; }
        public long? SpecialistId { get; set; }
        public int? StatusEventLogId { get; set; }
        public string DestinationControl { get; set; }
        public string DopNumber { get; set; }
        public DateTime? DopDate { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual FasetItem Type { get; set; }
        public virtual ICollection<AccountDocument> AccountDocuments { get; set; }
        public virtual ICollection<AccountPenaltyRemission> AccountPenaltyRemissions { get; set; }
        public virtual ICollection<AccountService4> AccountService4CloseDocs { get; set; }
        public virtual ICollection<AccountService4> AccountService4OpenDocs { get; set; }
        public virtual ICollection<AccountServiceDocument> AccountServiceDocuments { get; set; }
        public virtual ICollection<AccountServiceNorm> AccountServiceNorms { get; set; }
        public virtual ICollection<AccountServicePenaltyRemission> AccountServicePenaltyRemissions { get; set; }
        public virtual ICollection<AccountServiceTariff> AccountServiceTariffs { get; set; }
        public virtual ICollection<Apartment1> Apartment1s { get; set; }
        public virtual ICollection<ApartmentCounterBetweenCheckInterval> ApartmentCounterBetweenCheckIntervals { get; set; }
        public virtual ICollection<ApartmentNote> ApartmentNotes { get; set; }
        public virtual ICollection<ApartmentOwner> ApartmentOwners { get; set; }
        public virtual ICollection<DebtDocument> DebtDocuments { get; set; }
        public virtual ICollection<GroupOperation> GroupOperations { get; set; }
        public virtual ICollection<HouseCounterIndication> HouseCounterIndications { get; set; }
        public virtual ICollection<HouseProperty> HouseProperties { get; set; }
        public virtual ICollection<HouseServiceNorm> HouseServiceNorms { get; set; }
        public virtual ICollection<HouseServiceRestrictionsOnUnloading> HouseServiceRestrictionsOnUnloadings { get; set; }
        public virtual ICollection<HouseServiceTariff> HouseServiceTariffs { get; set; }
        public virtual ICollection<OrgDocumentTypeDoc> OrgDocumentTypeDocs { get; set; }
        public virtual ICollection<OrgDocumentsEventLog> OrgDocumentsEventLogs { get; set; }
        public virtual ICollection<OrganizationPenaltiesSuspension> OrganizationPenaltiesSuspensions { get; set; }
        public virtual ICollection<Remittee> Remittees { get; set; }
        public virtual ICollection<Service1> Service1s { get; set; }
        public virtual ICollection<ServiceCommission> ServiceCommissions { get; set; }
        public virtual ICollection<ServiceNorm> ServiceNorms { get; set; }
        public virtual ICollection<ServicePenalty> ServicePenalties { get; set; }
        public virtual ICollection<ServiceSplitBalance> ServiceSplitBalances { get; set; }
        public virtual ICollection<ServiceSplitDocument> ServiceSplitDocuments { get; set; }
        public virtual ICollection<ServiceSplitJn> ServiceSplitJns { get; set; }
        public virtual ICollection<ServiceSplitLink> ServiceSplitLinks { get; set; }
        public virtual ICollection<ServiceSplitPaymentPercent> ServiceSplitPaymentPercents { get; set; }
        public virtual ICollection<ServiceSplitPercent> ServiceSplitPercents { get; set; }
        public virtual ICollection<ServiceSplitTransfer> ServiceSplitTransfers { get; set; }
        public virtual ICollection<ServiceTariff> ServiceTariffs { get; set; }
        public virtual ICollection<ServiceTypeSubQuality> ServiceTypeSubQualities { get; set; }
        public virtual ICollection<StreamFile> StreamFiles { get; set; }
    }
}
