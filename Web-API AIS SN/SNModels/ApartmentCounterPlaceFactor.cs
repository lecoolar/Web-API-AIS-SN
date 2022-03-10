using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterPlaceFactor
    {
        public long Id { get; set; }
        public int PlaceId { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public decimal Value { get; set; }

        public virtual FasetItem Place { get; set; }
    }
}
