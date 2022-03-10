using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalAddressOrganizationSynonymsView
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public string OrgName { get; set; }
        public long? LocalAddressId { get; set; }
        public int? LocalAddressLevel { get; set; }
        public string LocalAddressName { get; set; }
        public string ParentLocalAddressName { get; set; }
        public string Synonym { get; set; }
    }
}
