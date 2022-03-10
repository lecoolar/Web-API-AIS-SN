using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeContextView
    {
        public short Id { get; set; }
        public long? ServiceTypeId { get; set; }
        public int? ServiceTypeCode { get; set; }
        public string ServiseTypeName { get; set; }
        public int? TypeContextId { get; set; }
        public string TypeContextName { get; set; }
    }
}
