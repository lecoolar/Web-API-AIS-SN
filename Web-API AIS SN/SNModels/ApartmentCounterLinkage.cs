using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterLinkage
    {
        public long Id { get; set; }
        public long ApartmentCounterId { get; set; }
        public long ApartmentId { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual ApartmentCounter ApartmentCounter { get; set; }
    }
}
