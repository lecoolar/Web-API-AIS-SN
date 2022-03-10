using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            BankAccountProviders = new HashSet<BankAccountProvider>();
            BankPaymentOrdersRecords = new HashSet<BankPaymentOrdersRecord>();
            HouseBankAccounts = new HashSet<HouseBankAccount>();
            Remittees = new HashSet<Remittee>();
        }

        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public long BankId { get; set; }
        public long OwnerId { get; set; }
        public bool IsPrimary { get; set; }
        public long? Code { get; set; }
        public string ExternalSystemCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? PropertyId { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual FasetItem Property { get; set; }
        public virtual ICollection<BankAccountProvider> BankAccountProviders { get; set; }
        public virtual ICollection<BankPaymentOrdersRecord> BankPaymentOrdersRecords { get; set; }
        public virtual ICollection<HouseBankAccount> HouseBankAccounts { get; set; }
        public virtual ICollection<Remittee> Remittees { get; set; }
    }
}
