using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestCountersView
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public long? CounterId { get; set; }
        public decimal? CounterIndication { get; set; }
        public decimal? NewCounterIndication { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public string CounterTypeName { get; set; }
        public string CounterNumber { get; set; }
        public string CounterName { get; set; }
    }
}
