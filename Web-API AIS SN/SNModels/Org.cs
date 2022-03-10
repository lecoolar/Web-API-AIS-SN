using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Org
    {
        public Org()
        {
            OrgFreeAccountMasks = new HashSet<OrgFreeAccountMask>();
            ServiceProviders = new HashSet<ServiceProvider>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public long? OrganizationId { get; set; }
        public decimal Commission { get; set; }

        public virtual Organization1 Organization { get; set; }
        public virtual ICollection<OrgFreeAccountMask> OrgFreeAccountMasks { get; set; }
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}
