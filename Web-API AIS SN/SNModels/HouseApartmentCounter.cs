using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseApartmentCounter
    {
        public long Id { get; set; }
        public long HouseCounterId { get; set; }
        public long ApartmentCounterId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
