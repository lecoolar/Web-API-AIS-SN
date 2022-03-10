using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CanonicalServicePropertiesView
    {
        public long Id { get; set; }
        public long CanonicalServiceId { get; set; }
        public string CanonicalServiceName { get; set; }
        public long SrvTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public short? FasetId { get; set; }
        public string FasetName { get; set; }
    }
}
