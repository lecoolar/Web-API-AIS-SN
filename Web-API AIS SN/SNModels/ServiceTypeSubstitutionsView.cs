using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSubstitutionsView
    {
        public long Id { get; set; }
        public long? SourceServiceTypeId { get; set; }
        public string SourceServiceTypeName { get; set; }
        public long DestinationServiceTypeId { get; set; }
        public string DestinationServiceTypeName { get; set; }
        public long? SourceServiceTypeIdByReport { get; set; }
        public string SourceServiceTypeNameByReport { get; set; }
    }
}
