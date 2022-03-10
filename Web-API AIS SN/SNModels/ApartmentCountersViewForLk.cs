using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCountersViewForLk
    {
        public long CounterId { get; set; }
        public long ApartmentId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public int? CounterSize { get; set; }
        public decimal? Factor { get; set; }
        public string Stamp { get; set; }
        public DateTime? StampDate { get; set; }
        public long? MarkId { get; set; }
        public string MarkName { get; set; }
        public int? CounterTypeId { get; set; }
        public string CounterTypeName { get; set; }
        public int? MaddleTypeId { get; set; }
        public string MaddleTypeName { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long? LastCheckIntervalId { get; set; }
        public DateTime? LastCheckIntervalFromDate { get; set; }
        public decimal? LastCheckIntervalFromIndication { get; set; }
        public DateTime? LastCheckIntervalToDate { get; set; }
        public decimal? LastCheckIntervalToIndication { get; set; }
        public decimal? Power { get; set; }
        public long? CounterServiceTypeId { get; set; }
        public string CounterServiceTypeName { get; set; }
        public long? OldCounterId { get; set; }
        public DateTime? LiquidationRefDate { get; set; }
        public bool? IsRemotelyRemoteIndications { get; set; }
        public DateTime? DateSealing { get; set; }
        public string Comment { get; set; }
        public string CounterNumberAismeter { get; set; }
    }
}
