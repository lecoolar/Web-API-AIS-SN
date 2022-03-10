using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalAddressOrganizationSynonym
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public long? LocalAddressId { get; set; }
        public string Synonym { get; set; }
        public int? LocalAddressLevel { get; set; }
    }
}
