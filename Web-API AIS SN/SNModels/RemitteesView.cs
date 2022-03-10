using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RemitteesView
    {
        public long Id { get; set; }
        public long RemitteeOrgId { get; set; }
        public long? BankAccountId { get; set; }
        public decimal? BankAccountNumber { get; set; }
        public string BankName { get; set; }
        public string BankOwnerName { get; set; }
        public int RemitteeOrgCode { get; set; }
        public string RemitteeOrgShortName { get; set; }
        public long ClientDocId { get; set; }
        public string ClientDocNumber { get; set; }
        public DateTime? ClientDocIssueDate { get; set; }
        public long? ClientDocOrgId { get; set; }
        public string ClientDocOrgName { get; set; }
        public string Comment { get; set; }
    }
}
