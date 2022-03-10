using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentEquipmentHousekeepingsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long EquipmentId { get; set; }
        public long HousekeepingId { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public string EquipmentTypeName { get; set; }
        public string EquipmentInfo { get; set; }
        public DateTime? EquipmentDateb { get; set; }
        public DateTime? EquipmentDatee { get; set; }
        public string HousekeepingTypeName { get; set; }
        public string HousekeepingName { get; set; }
        public decimal HousekeepingSquare { get; set; }
        public DateTime? HousekeepingDateb { get; set; }
        public DateTime? HousekeepingDatee { get; set; }
        public DateTime HousekeepingDatec { get; set; }
    }
}
