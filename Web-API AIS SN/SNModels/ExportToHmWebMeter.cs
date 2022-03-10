using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebMeter
    {
        public long RemoteId { get; set; }
        public int IsCollectiveCounter { get; set; }
        public string TypeCode { get; set; }
        public long RemoteOrganizationId { get; set; }
        public long RemoteHouseAddrId { get; set; }
        public string RoomNumber { get; set; }
        public bool? RoomTypeIsLiving { get; set; }
        public string DeviceSerialNumber { get; set; }
        public string DeviceManufacturer { get; set; }
        public string DeviceModel { get; set; }
        public DateTime? DateInstalled { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateFactorySealed { get; set; }
        public DateTime? VerificationFirstDate { get; set; }
        public int? VerificationInterval { get; set; }
        public bool? HasDispatching { get; set; }
        public string DispatchingInfo { get; set; }
        public bool? HasTemperatureSensor { get; set; }
        public string TemperatureSensorInfo { get; set; }
        public bool? HasPressureSensor { get; set; }
        public string PressureSensorInfo { get; set; }
        public string ResourceId { get; set; }
        public decimal? BaseValue { get; set; }
        public decimal? ElectricalTransformationRatio { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }
        public long TransportMeterId { get; set; }
        public decimal? BaseValue2 { get; set; }
        public decimal? BaseValue3 { get; set; }
    }
}
