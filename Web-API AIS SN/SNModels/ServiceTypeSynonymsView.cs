using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSynonymsView
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public string ServiceName { get; set; }
        public long? ServiceTypeId { get; set; }
        public int? ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
        public int OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
    }
}
