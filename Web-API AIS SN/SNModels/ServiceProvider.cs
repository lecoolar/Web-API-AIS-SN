using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceProvider
    {
        public ServiceProvider()
        {
            Account1s = new HashSet<Account1>();
            Payments = new HashSet<Payment>();
        }

        public long Id { get; set; }
        public long OrgId { get; set; }
        public long ServiceId { get; set; }

        public virtual Org Org { get; set; }
        public virtual Service2 Service { get; set; }
        public virtual ICollection<Account1> Account1s { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
