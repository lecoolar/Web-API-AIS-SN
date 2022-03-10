using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Treaty
    {
        public Treaty()
        {
            ServiceTreaties = new HashSet<ServiceTreaty>();
        }

        public long Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public long OrgId { get; set; }
        public int ServiceTypeGroupCode { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual ICollection<ServiceTreaty> ServiceTreaties { get; set; }
    }
}
