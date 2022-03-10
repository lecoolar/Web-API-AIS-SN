using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalAddressSynonym
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public string Name { get; set; }
        public byte Level { get; set; }
        public long? LocalAddressId { get; set; }
        public long? ParentLocalAddressId { get; set; }
        public long? ParentId { get; set; }
        public string DistrictName { get; set; }
        public long? ProcessingId { get; set; }

        public virtual LocalAddress LocalAddress { get; set; }
        public virtual Organization1 Org { get; set; }
        public virtual LocalAddress ParentLocalAddress { get; set; }
    }
}
