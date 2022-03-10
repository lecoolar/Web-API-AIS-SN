using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentEquipmentCountersView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentName { get; set; }
        public long EquipmentId { get; set; }
        public int EquipmentTypeId { get; set; }
        public string EquipmentTypeName { get; set; }
        public string EquipmentInfo { get; set; }
        public DateTime EquipmentCreated { get; set; }
        public DateTime? EquipmentFromDate { get; set; }
        public DateTime? EquipmentToDate { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long CounterId { get; set; }
        public string CounterTypeName { get; set; }
        public string CounterName { get; set; }
        public DateTime CounterDateb { get; set; }
        public DateTime? CounterDatee { get; set; }
    }
}
