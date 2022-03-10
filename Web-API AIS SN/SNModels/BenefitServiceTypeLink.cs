using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitServiceTypeLink
    {
        public long BenefitServiceTypeId { get; set; }
        public long SrvTypeId { get; set; }

        public virtual BenefitServiceType BenefitServiceType { get; set; }
        public virtual ServiceType SrvType { get; set; }
    }
}
