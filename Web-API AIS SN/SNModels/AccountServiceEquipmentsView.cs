using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceEquipmentsView
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long? ApartmentEquipmentId { get; set; }
        public int? ApartmentEquipmentTypeId { get; set; }
        public string ApartmentEquipmentTypeName { get; set; }
        public string ApartmentEquipmentInfo { get; set; }
        public DateTime? ApartmentEquipmentFromDate { get; set; }
        public DateTime? ApartmentEquipmentToDate { get; set; }
        public DateTime? ApartmentEquipmentCreated { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
