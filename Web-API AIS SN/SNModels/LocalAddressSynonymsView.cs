using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalAddressSynonymsView
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public string Name { get; set; }
        public byte Level { get; set; }
        public long? LocalAddressId { get; set; }
        public long? ParentLocalAddressId { get; set; }
        public long? ParentId { get; set; }
        public string DistrictName { get; set; }
        public string FullName { get; set; }
        public long? ProcessingId { get; set; }
    }
}
