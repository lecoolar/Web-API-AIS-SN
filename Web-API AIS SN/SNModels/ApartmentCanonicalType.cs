using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCanonicalType
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public int? TypeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? Created { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual FasetItem Type { get; set; }
    }
}
