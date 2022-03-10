using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T832293ApartmentCounter
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public int? TypeId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public int? CounterSize { get; set; }
        public decimal? Factor { get; set; }
        public int? MaddleType { get; set; }
        public string Stamp { get; set; }
        public DateTime? StampDate { get; set; }
        public long? MarkId { get; set; }
        public int? PlaceId { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long KodCl { get; set; }
        public long KodObj { get; set; }
        public int? TypeScaleCounterId { get; set; }
        public string PointAccounting { get; set; }
        public decimal? Power { get; set; }
        public long? CounterServiceTypeId { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public byte? Act { get; set; }
        public int? StatusAskupe { get; set; }
        public int? CommunalShareTypeId { get; set; }
        public byte? ReesterOrderNumber { get; set; }
        public int? CloseReasonId { get; set; }
        public string CounterCodeProvider { get; set; }
        public DateTime? CounterRelease { get; set; }
        public int? UnitMeasureId { get; set; }
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
        public string CounterSmallName { get; set; }
        public int? CounterSmallNameId { get; set; }
    }
}
