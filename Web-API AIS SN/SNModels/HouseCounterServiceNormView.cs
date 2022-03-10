using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterServiceNormView
    {
        public long Id { get; set; }
        public long HouseCounterId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public string TypeCounterName { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public long ServiceId { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public long ProviderId { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public DateTime ServiceFromDate { get; set; }
        public DateTime? ServiceToDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
