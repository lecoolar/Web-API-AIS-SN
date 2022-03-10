using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationWasteClassificator
    {
        public long Id { get; set; }
        public long OrganizationId { get; set; }
        public int PropertyId { get; set; }

        public virtual Organization1 Organization { get; set; }
        public virtual FasetItem Property { get; set; }
    }
}
