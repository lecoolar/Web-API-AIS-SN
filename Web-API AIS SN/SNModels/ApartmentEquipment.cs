using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentEquipment
    {
        public ApartmentEquipment()
        {
            AccountServiceEquipments = new HashSet<AccountServiceEquipment>();
            ApartmentEquipmentCounters = new HashSet<ApartmentEquipmentCounter>();
            ApartmentEquipmentHousekeepings = new HashSet<ApartmentEquipmentHousekeeping>();
        }

        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public int TypeEquipment { get; set; }
        public string SerialNumber { get; set; }
        public string Info { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual FasetItem TypeEquipmentNavigation { get; set; }
        public virtual ICollection<AccountServiceEquipment> AccountServiceEquipments { get; set; }
        public virtual ICollection<ApartmentEquipmentCounter> ApartmentEquipmentCounters { get; set; }
        public virtual ICollection<ApartmentEquipmentHousekeeping> ApartmentEquipmentHousekeepings { get; set; }
    }
}
