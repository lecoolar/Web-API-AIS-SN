using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCountersView
    {
        public long CounterId { get; set; }
        public long ApartmentId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public long AdrId { get; set; }
        public string AddressName { get; set; }
        public int? CounterSize { get; set; }
        public decimal? Factor { get; set; }
        public string Stamp { get; set; }
        public DateTime? StampDate { get; set; }
        public long? MarkId { get; set; }
        public string MarkName { get; set; }
        public int? PlaceId { get; set; }
        public string PlaceName { get; set; }
        public int? CounterTypeId { get; set; }
        public string CounterTypeName { get; set; }
        public int? MaddleTypeId { get; set; }
        public string MaddleTypeName { get; set; }
        public int? TypeScaleCounterId { get; set; }
        public string TypeScaleCounterName { get; set; }
        public string PointAccounting { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long? CounterIndicationsAverageMounthId { get; set; }
        public decimal? ValAverageMounth { get; set; }
        public DateTime? ValDateAverageMounth { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public long? LastCheckIntervalId { get; set; }
        public DateTime? LastCheckIntervalFromDate { get; set; }
        public decimal? LastCheckIntervalFromIndication { get; set; }
        public DateTime? LastCheckIntervalToDate { get; set; }
        public decimal? LastCheckIntervalToIndication { get; set; }
        public decimal? Power { get; set; }
        public long? CounterServiceTypeId { get; set; }
        public string CounterServiceTypeName { get; set; }
        public byte? Act { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public int? StatusAskupe { get; set; }
        public string StatusAskupename { get; set; }
        public int? CommunalShareTypeId { get; set; }
        public string CommunalShareTypeName { get; set; }
        public byte? ReesterOrderNumber { get; set; }
        public int? CloseReasonId { get; set; }
        public string CloseReasonName { get; set; }
        public string CounterCodeProvider { get; set; }
        public DateTime? CounterRelease { get; set; }
        public int? UnitMeasureId { get; set; }
        public string UnitMeasureName { get; set; }
        public int? Fraction { get; set; }
        public long? ModelId { get; set; }
        public bool? IsRemotelyRemoteIndications { get; set; }
        public DateTime? DateSealing { get; set; }
        public string InfoSensorTemperature { get; set; }
        public string InfoSensorPressure { get; set; }
        public string ExternalCode { get; set; }
        public long? OldCounterId { get; set; }
        public DateTime? LiquidationRefDate { get; set; }
        public string Comment { get; set; }
        public string CounterNumberAismeter { get; set; }
        public int? CounterSmallNameId { get; set; }
        public string CounterSmallName { get; set; }
    }
}
