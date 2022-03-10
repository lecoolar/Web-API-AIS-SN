using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationGroupContent
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public long? OrganizationId { get; set; }

        public virtual OrganizationGroup Group { get; set; }
        public virtual Organization1 Organization { get; set; }
    }
}
