using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Remittee
    {
        public Remittee()
        {
            RemitteePaymentOrders = new HashSet<RemitteePaymentOrder>();
            RemitteeServices = new HashSet<RemitteeService>();
        }

        public long Id { get; set; }
        public long RemitteeOrgId { get; set; }
        public long ClientDocId { get; set; }
        public long? BankAccountId { get; set; }

        public virtual BankAccount BankAccount { get; set; }
        public virtual OrgDocument ClientDoc { get; set; }
        public virtual Organization1 RemitteeOrg { get; set; }
        public virtual ICollection<RemitteePaymentOrder> RemitteePaymentOrders { get; set; }
        public virtual ICollection<RemitteeService> RemitteeServices { get; set; }
    }
}
