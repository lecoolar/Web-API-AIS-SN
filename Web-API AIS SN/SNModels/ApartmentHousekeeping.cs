using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentHousekeeping
    {
        public ApartmentHousekeeping()
        {
            ApartmentEquipmentHousekeepings = new HashSet<ApartmentEquipmentHousekeeping>();
        }

        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public int TypeHk { get; set; }
        public decimal SquareHk { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public string NameHk { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual FasetItem TypeHkNavigation { get; set; }
        public virtual ICollection<ApartmentEquipmentHousekeeping> ApartmentEquipmentHousekeepings { get; set; }
    }
}
