using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCountersIndicationsInputViewForMpa
    {
        public long? Id { get; set; }
        public long ApartmentId { get; set; }
        public long CounterId { get; set; }
        public string CounterName { get; set; }
        public int? CounterTypeId { get; set; }
        public string CounterTypeName { get; set; }
        public string CounterNumber { get; set; }
        public int? CounterSmallNameId { get; set; }
        public string CounterSmallName { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public long? MarkId { get; set; }
        public string MarkName { get; set; }
        public long? ModelId { get; set; }
        public string ModelName { get; set; }
        public int CounterSize { get; set; }
        public decimal? Factor { get; set; }
        public string AccountNumber { get; set; }
        public long? CounterServiceTypeId { get; set; }
        public string CounterServiceTypeName { get; set; }
        public string CounterServiceTypeAlias { get; set; }
        public decimal Val { get; set; }
        public string Stamp { get; set; }
        public DateTime? StampDate { get; set; }
    }
}
