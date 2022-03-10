using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountCase
    {
        public AccountCase()
        {
            AccountCaseStatuses = new HashSet<AccountCaseStatus>();
            AccountCasesServices = new HashSet<AccountCasesService>();
        }

        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal Debt { get; set; }
        public string Comment { get; set; }

        public virtual Account Account { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AccountCaseStatus> AccountCaseStatuses { get; set; }
        public virtual ICollection<AccountCasesService> AccountCasesServices { get; set; }
    }
}
