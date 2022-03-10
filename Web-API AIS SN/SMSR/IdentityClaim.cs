using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class IdentityClaim
    {
        public int Id { get; set; }
        public int IdentityResourceId { get; set; }
        public string Type { get; set; }

        public virtual IdentityResource IdentityResource { get; set; }
    }
}
