using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrder
    {
        public PaymentOrder()
        {
            GroupOperations = new HashSet<GroupOperation>();
            PaymentOrderAccounts = new HashSet<PaymentOrderAccount>();
        }

        public long Id { get; set; }
        public string Number { get; set; }
        public DateTime? Period { get; set; }
        public DateTime? FromDate { get; set; }
        public long? ProviderId { get; set; }
        public long? LegalEntityId { get; set; }
        public decimal? Summ { get; set; }
        public long? BankAccountId { get; set; }
        public DateTime Created { get; set; }
        public bool? Archived { get; set; }
        public long? ReportId { get; set; }
        public long? UserId { get; set; }
        public string BankBik { get; set; }
        public string BankLoroAccount { get; set; }
        public string BankInfo { get; set; }
        public decimal? TotalSquareSumm { get; set; }
        public long? CountLine { get; set; }
        public string PaymentOwner { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string ChiefAccountant { get; set; }
        public string Manager { get; set; }
        public string AddrInfo { get; set; }
        public string RecipientName { get; set; }
        public string DocumentInfo { get; set; }
        public long? PaymentOrderTemplateId { get; set; }
        public string TypePeriod { get; set; }
        public string OrgLegalEntityInn { get; set; }
        public string OrgLegalEntityKpp { get; set; }
        public bool? IsOnlyPeni { get; set; }
        public string ManagerPosition { get; set; }
        public string PowerOfAttorneyChiefAccountant { get; set; }
        public string PowerOfAttorneyManager { get; set; }
        public string Barcode { get; set; }
        public bool? IsAdvance { get; set; }
        public bool? IsSaldo { get; set; }
        public long? OrgDocumentsId { get; set; }
        public DateTime? DateNotice { get; set; }
        public long? ParentId { get; set; }

        public virtual ICollection<GroupOperation> GroupOperations { get; set; }
        public virtual ICollection<PaymentOrderAccount> PaymentOrderAccounts { get; set; }
    }
}
