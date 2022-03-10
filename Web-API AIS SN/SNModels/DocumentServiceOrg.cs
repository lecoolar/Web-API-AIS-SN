using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DocumentServiceOrg
    {
        public long Id { get; set; }
        public long DocumentServiceId { get; set; }
        public long OrgId { get; set; }

        public virtual DocumentService DocumentService { get; set; }
        public virtual Organization1 Org { get; set; }
    }
}
