using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AreaOrganization
    {
        public long Id { get; set; }
        public long AreaId { get; set; }
        public long OrgId { get; set; }

        public virtual Area Area { get; set; }
        public virtual Organization1 Org { get; set; }
    }
}
