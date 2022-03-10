using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EntranceApartment
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long HouseEntranceId { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual HouseEntrance HouseEntrance { get; set; }
    }
}
