using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypesKbkview
    {
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string Kbk { get; set; }
        public int? ConsumerGroupId { get; set; }
        public string ConsumerGroupName { get; set; }
        public int? ExternalServiceTypeId { get; set; }
        public string ExternalServiceTypeName { get; set; }
    }
}
