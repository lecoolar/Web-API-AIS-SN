using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterShare
    {
        public long Id { get; set; }
        public long ApartmentCounterId { get; set; }
        public decimal? Share { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }

        public virtual ApartmentCounter ApartmentCounter { get; set; }
    }
}
