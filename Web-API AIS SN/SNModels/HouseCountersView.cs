using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCountersView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public string TypeCounterName { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public int? Capacity { get; set; }
        public long? MarkId { get; set; }
        public string MarkName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? ServiceTypeId { get; set; }
        public int? ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
        public string Stamp { get; set; }
        public DateTime? StampDate { get; set; }
        public string AdrName { get; set; }
        public long? AdrId { get; set; }
        public long? AdrParentId { get; set; }
        public decimal? Factor { get; set; }
        public bool? IsInternal { get; set; }
        public string Note { get; set; }
        public string PointAccounting { get; set; }
        public int? StatusAskupe { get; set; }
        public string StatusAskupename { get; set; }
        public bool IsAvailableAvgConsumption { get; set; }
        public int? MeasureUnitsId { get; set; }
        public string MeasureUnitsName { get; set; }
        public long? ModelId { get; set; }
        public bool? IsRemotelyRemoteIndications { get; set; }
        public DateTime? DateSealing { get; set; }
        public string InfoSensorTemperature { get; set; }
        public string InfoSensorPressure { get; set; }
        public string ExternalCode { get; set; }
        public DateTime? LastCheckIntervalFromDate { get; set; }
        public DateTime? LastCheckIntervalToDate { get; set; }
        public DateTime? LiquidationRefDate { get; set; }
        public string Comment { get; set; }
        public bool? IsNotUnloadGis { get; set; }
        public bool? IsOwnedRso { get; set; }
        public long? OldCounterId { get; set; }
    }
}
