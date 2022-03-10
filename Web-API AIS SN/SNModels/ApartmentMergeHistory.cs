using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentMergeHistory
    {
        public long Id { get; set; }
        public long PreviousApartmentId { get; set; }
        public long NextApartmentId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }

        public virtual Apartment1 NextApartment { get; set; }
        public virtual Apartment1 PreviousApartment { get; set; }
    }
}
