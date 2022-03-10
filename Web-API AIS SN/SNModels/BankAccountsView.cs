using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BankAccountsView
    {
        public long Id { get; set; }
        public decimal? AccountNumber { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }
        public string Bik { get; set; }
        public string BankCity { get; set; }
        public decimal? LoroAccount { get; set; }
        public long OwnerId { get; set; }
        public string OwnerName { get; set; }
        public long? PersonId { get; set; }
        public long? OrgId { get; set; }
        public bool IsPrimary { get; set; }
        public long? Code { get; set; }
        public string ExternalSystemCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? PropertyId { get; set; }
        public string PropertyName { get; set; }
    }
}
