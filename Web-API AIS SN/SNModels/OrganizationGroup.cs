using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationGroup
    {
        public OrganizationGroup()
        {
            OrganizationGroupContents = new HashSet<OrganizationGroupContent>();
        }

        public long Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<OrganizationGroupContent> OrganizationGroupContents { get; set; }
    }
}
