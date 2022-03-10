using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSynonym
    {
        public long Id { get; set; }
        public string ServiceName { get; set; }
        public long OrgId { get; set; }
        public long? ServiceTypeId { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
