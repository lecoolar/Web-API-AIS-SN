using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AreaApartment
    {
        public long Id { get; set; }
        public long AreaId { get; set; }
        public long ApartmentId { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual Area Area { get; set; }
    }
}
