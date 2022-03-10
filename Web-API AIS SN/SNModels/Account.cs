using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Account
    {
        public Account()
        {
            AccountCases = new HashSet<AccountCase>();
            AccountCasesServices = new HashSet<AccountCasesService>();
            AccountCashlessProperties = new HashSet<AccountCashlessProperty>();
            AccountDocuments = new HashSet<AccountDocument>();
            AccountHouseHolders = new HashSet<AccountHouseHolder>();
            AccountInfoMessages = new HashSet<AccountInfoMessage>();
            AccountNumbers = new HashSet<AccountNumber>();
            AccountPenaltyRemissions = new HashSet<AccountPenaltyRemission>();
            AccountProperties = new HashSet<AccountProperty>();
            AccountProviders = new HashSet<AccountProvider>();
            AccountReports = new HashSet<AccountReport>();
            AccountService4s = new HashSet<AccountService4>();
            ApartmentRequestAccounts = new HashSet<ApartmentRequestAccount>();
            ApartmentRequests = new HashSet<ApartmentRequest>();
            AreaAccounts = new HashSet<AreaAccount>();
            BenefitAccounts = new HashSet<BenefitAccount>();
            CacheSnaccounts = new HashSet<CacheSnaccount>();
            DebtAccounts = new HashSet<DebtAccount>();
            DebtAffairs = new HashSet<DebtAffair>();
            DebtNotificationsRendereds = new HashSet<DebtNotificationsRendered>();
            DebtorCards = new HashSet<DebtorCard>();
            JnCommissions = new HashSet<JnCommission>();
            JnSaldoAccounts = new HashSet<JnSaldoAccount>();
            PersonDeclarations = new HashSet<PersonDeclaration>();
            Requests = new HashSet<Request>();
            SendQueries = new HashSet<SendQuery>();
            UserAccountServices = new HashSet<UserAccountService>();
        }

        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string Number { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public long? OwnerId { get; set; }
        public string OwnerName { get; set; }
        public bool? NeedOwnerPresence { get; set; }
        public string Comment { get; set; }
        public bool? NeedPrintNotice { get; set; }
        public string IdentityCardNumber { get; set; }
        public string IdentityCardHolderName { get; set; }
        public string DocInfo { get; set; }
        public long? NoticeAdrId { get; set; }
        public int? UseAccountServiceGroups { get; set; }
        public string NoticeAdrName { get; set; }
        public bool? IsCloseInPaymentSystem { get; set; }
        public bool? IsArchived { get; set; }
        public long? AdministrationDistrictId { get; set; }
        public string NoticeEmail { get; set; }
        public int? TypeBudget { get; set; }
        public bool NeedEmailNotice { get; set; }
        public DateTime? DateComment { get; set; }
        public string NoticeAdrPostalIndex { get; set; }
        public bool NeedOnlyEmailNotice { get; set; }
        public bool? SetCounterIndicationWoauth { get; set; }
        public bool NeedSendAndPrintNotice { get; set; }
        public string SbpQrCode { get; set; }
        public string QrcId { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual LocalAddress NoticeAdr { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual FasetItem TypeBudgetNavigation { get; set; }
        public virtual ICollection<AccountCase> AccountCases { get; set; }
        public virtual ICollection<AccountCasesService> AccountCasesServices { get; set; }
        public virtual ICollection<AccountCashlessProperty> AccountCashlessProperties { get; set; }
        public virtual ICollection<AccountDocument> AccountDocuments { get; set; }
        public virtual ICollection<AccountHouseHolder> AccountHouseHolders { get; set; }
        public virtual ICollection<AccountInfoMessage> AccountInfoMessages { get; set; }
        public virtual ICollection<AccountNumber> AccountNumbers { get; set; }
        public virtual ICollection<AccountPenaltyRemission> AccountPenaltyRemissions { get; set; }
        public virtual ICollection<AccountProperty> AccountProperties { get; set; }
        public virtual ICollection<AccountProvider> AccountProviders { get; set; }
        public virtual ICollection<AccountReport> AccountReports { get; set; }
        public virtual ICollection<AccountService4> AccountService4s { get; set; }
        public virtual ICollection<ApartmentRequestAccount> ApartmentRequestAccounts { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequests { get; set; }
        public virtual ICollection<AreaAccount> AreaAccounts { get; set; }
        public virtual ICollection<BenefitAccount> BenefitAccounts { get; set; }
        public virtual ICollection<CacheSnaccount> CacheSnaccounts { get; set; }
        public virtual ICollection<DebtAccount> DebtAccounts { get; set; }
        public virtual ICollection<DebtAffair> DebtAffairs { get; set; }
        public virtual ICollection<DebtNotificationsRendered> DebtNotificationsRendereds { get; set; }
        public virtual ICollection<DebtorCard> DebtorCards { get; set; }
        public virtual ICollection<JnCommission> JnCommissions { get; set; }
        public virtual ICollection<JnSaldoAccount> JnSaldoAccounts { get; set; }
        public virtual ICollection<PersonDeclaration> PersonDeclarations { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<SendQuery> SendQueries { get; set; }
        public virtual ICollection<UserAccountService> UserAccountServices { get; set; }
    }
}
