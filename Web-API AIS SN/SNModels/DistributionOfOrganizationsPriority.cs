using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DistributionOfOrganizationsPriority
    {
        public long Id { get; set; }
        public long AccountHouseHolderId { get; set; }
        public long ServiceOrganizationId { get; set; }
        public bool? IsHouseHolder { get; set; }
        public bool? IsServiceProvider { get; set; }
        public int Priority { get; set; }

        public virtual Organization1 AccountHouseHolder { get; set; }
        public virtual Organization1 ServiceOrganization { get; set; }
    }
}
