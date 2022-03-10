﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class IdentityResource
    {
        public IdentityResource()
        {
            IdentityClaims = new HashSet<IdentityClaim>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public bool Emphasize { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public bool Required { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }

        public virtual ICollection<IdentityClaim> IdentityClaims { get; set; }
    }
}
