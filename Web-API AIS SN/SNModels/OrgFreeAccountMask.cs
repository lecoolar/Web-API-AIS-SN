using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrgFreeAccountMask
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public string Mask { get; set; }

        public virtual Org Org { get; set; }
    }
}
