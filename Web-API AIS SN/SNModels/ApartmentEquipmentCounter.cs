using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentEquipmentCounter
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long EquipmentId { get; set; }
        public long CounterId { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual ApartmentCounter Counter { get; set; }
        public virtual ApartmentEquipment Equipment { get; set; }
    }
}
