using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationInfo
    {
        public long OrgId { get; set; }
        public string Info { get; set; }

        public virtual Organization1 Org { get; set; }
    }
}
