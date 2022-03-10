using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentType
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public DateTime FromDate { get; set; }
        public short? FasetId { get; set; }
        public int FasetItemId { get; set; }
        public DateTime Created { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual Faset Faset { get; set; }
        public virtual FasetItem FasetItem { get; set; }
    }
}
