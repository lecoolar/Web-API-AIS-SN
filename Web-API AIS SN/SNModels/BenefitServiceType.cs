using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitServiceType
    {
        public BenefitServiceType()
        {
            BenefitAreas = new HashSet<BenefitArea>();
            BenefitServiceTypeLinks = new HashSet<BenefitServiceTypeLink>();
        }

        public long Id { get; set; }
        public long Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public long OrgId { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual ICollection<BenefitArea> BenefitAreas { get; set; }
        public virtual ICollection<BenefitServiceTypeLink> BenefitServiceTypeLinks { get; set; }
    }
}
