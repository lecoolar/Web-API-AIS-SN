using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseEntrance
    {
        public HouseEntrance()
        {
            EntranceApartments = new HashSet<EntranceApartment>();
        }

        public long Id { get; set; }
        public long HouseId { get; set; }
        public string Entrance { get; set; }
        public int? Floors { get; set; }

        public virtual House House { get; set; }
        public virtual ICollection<EntranceApartment> EntranceApartments { get; set; }
    }
}
