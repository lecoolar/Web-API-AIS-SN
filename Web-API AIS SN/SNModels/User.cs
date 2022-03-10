using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class User
    {
        public User()
        {
            AccountCaseStatuses = new HashSet<AccountCaseStatus>();
            AccountCases = new HashSet<AccountCase>();
            AccountProperties = new HashSet<AccountProperty>();
            AccountReports = new HashSet<AccountReport>();
            Action1s = new HashSet<Action1>();
            ApartmentCounterBetweenCheckIntervals = new HashSet<ApartmentCounterBetweenCheckInterval>();
            ApartmentCounterCheckIntervals = new HashSet<ApartmentCounterCheckInterval>();
            ApartmentCounterIndication1s = new HashSet<ApartmentCounterIndication1>();
            ApartmentCounterSeals = new HashSet<ApartmentCounterSeal>();
            ApartmentCounterVolumes = new HashSet<ApartmentCounterVolume>();
            ApartmentCounters = new HashSet<ApartmentCounter>();
            ApartmentRequestAnswerUsers = new HashSet<ApartmentRequest>();
            ApartmentRequestUsers = new HashSet<ApartmentRequest>();
            ApartmentResidents = new HashSet<ApartmentResident>();
            Calc2s = new HashSet<Calc2>();
            DebtAccounts = new HashSet<DebtAccount>();
            EventRegistrations = new HashSet<EventRegistration>();
            ExportOperations = new HashSet<ExportOperation>();
            FavoriteReportTemplates = new HashSet<FavoriteReportTemplate>();
            GroupOperations = new HashSet<GroupOperation>();
            HouseCounterBetweenCheckIntervals = new HashSet<HouseCounterBetweenCheckInterval>();
            HouseCounterIndications = new HashSet<HouseCounterIndication>();
            HouseRequests = new HashSet<HouseRequest>();
            PaymentMoreFixedSums = new HashSet<PaymentMoreFixedSum>();
            PaymentOrderPacks = new HashSet<PaymentOrderPack>();
            Payments = new HashSet<Payment>();
            Reesters = new HashSet<Reester>();
            Requests = new HashSet<Request>();
            ServiceSplitDocuments = new HashSet<ServiceSplitDocument>();
            Sessions = new HashSet<Session>();
            UserAccountServices = new HashSet<UserAccountService>();
            UserAddresses = new HashSet<UserAddress>();
            UserMenuItemGroups = new HashSet<UserMenuItemGroup>();
            UserOrganizations = new HashSet<UserOrganization>();
            UserReportTemplates = new HashSet<UserReportTemplate>();
            UserRights = new HashSet<UserRight>();
            UserServiceTypes = new HashSet<UserServiceType>();
            UserUnitOrganizations = new HashSet<UserUnitOrganization>();
            UserUpdates = new HashSet<UserUpdate>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public bool IsLocked { get; set; }
        public long? AreaId { get; set; }
        public int? PositionId { get; set; }
        public long? OrgId { get; set; }
        public int? UserJobId { get; set; }
        public string Description { get; set; }
        public int? PaymentAgentTypeId { get; set; }
        public bool IsWindowsLogin { get; set; }
        public string SsoSubjectId { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual FasetItem PaymentAgentType { get; set; }
        public virtual FasetItem Position { get; set; }
        public virtual FasetItem UserJob { get; set; }
        public virtual ICollection<AccountCaseStatus> AccountCaseStatuses { get; set; }
        public virtual ICollection<AccountCase> AccountCases { get; set; }
        public virtual ICollection<AccountProperty> AccountProperties { get; set; }
        public virtual ICollection<AccountReport> AccountReports { get; set; }
        public virtual ICollection<Action1> Action1s { get; set; }
        public virtual ICollection<ApartmentCounterBetweenCheckInterval> ApartmentCounterBetweenCheckIntervals { get; set; }
        public virtual ICollection<ApartmentCounterCheckInterval> ApartmentCounterCheckIntervals { get; set; }
        public virtual ICollection<ApartmentCounterIndication1> ApartmentCounterIndication1s { get; set; }
        public virtual ICollection<ApartmentCounterSeal> ApartmentCounterSeals { get; set; }
        public virtual ICollection<ApartmentCounterVolume> ApartmentCounterVolumes { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounters { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequestAnswerUsers { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequestUsers { get; set; }
        public virtual ICollection<ApartmentResident> ApartmentResidents { get; set; }
        public virtual ICollection<Calc2> Calc2s { get; set; }
        public virtual ICollection<DebtAccount> DebtAccounts { get; set; }
        public virtual ICollection<EventRegistration> EventRegistrations { get; set; }
        public virtual ICollection<ExportOperation> ExportOperations { get; set; }
        public virtual ICollection<FavoriteReportTemplate> FavoriteReportTemplates { get; set; }
        public virtual ICollection<GroupOperation> GroupOperations { get; set; }
        public virtual ICollection<HouseCounterBetweenCheckInterval> HouseCounterBetweenCheckIntervals { get; set; }
        public virtual ICollection<HouseCounterIndication> HouseCounterIndications { get; set; }
        public virtual ICollection<HouseRequest> HouseRequests { get; set; }
        public virtual ICollection<PaymentMoreFixedSum> PaymentMoreFixedSums { get; set; }
        public virtual ICollection<PaymentOrderPack> PaymentOrderPacks { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Reester> Reesters { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<ServiceSplitDocument> ServiceSplitDocuments { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<UserAccountService> UserAccountServices { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<UserMenuItemGroup> UserMenuItemGroups { get; set; }
        public virtual ICollection<UserOrganization> UserOrganizations { get; set; }
        public virtual ICollection<UserReportTemplate> UserReportTemplates { get; set; }
        public virtual ICollection<UserRight> UserRights { get; set; }
        public virtual ICollection<UserServiceType> UserServiceTypes { get; set; }
        public virtual ICollection<UserUnitOrganization> UserUnitOrganizations { get; set; }
        public virtual ICollection<UserUpdate> UserUpdates { get; set; }
    }
}
