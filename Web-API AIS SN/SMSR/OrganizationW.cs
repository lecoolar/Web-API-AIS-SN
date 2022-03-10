using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class OrganizationW
    {
        public long OrgId { get; set; }
        public long WebServiceId { get; set; }

        public virtual Organization Org { get; set; }
        public virtual WebService WebService { get; set; }
    }
}
