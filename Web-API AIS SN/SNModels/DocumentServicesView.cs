using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DocumentServicesView
    {
        public long Id { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Number { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public long AgentId { get; set; }
        public string AgentName { get; set; }
        public decimal? MaxSumm { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
