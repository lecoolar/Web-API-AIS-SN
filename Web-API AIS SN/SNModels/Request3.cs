using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Request3
    {
        public long Id { get; set; }
        public long? NodeId { get; set; }
        public long? NodeServiceId { get; set; }
        public long? NodeRequestId { get; set; }
        public long? LocalRequestId { get; set; }
        public long? CalcId { get; set; }
        public long? CalcNodeId { get; set; }
    }
}
