using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentTkoplatform
    {
        public ApartmentTkoplatform()
        {
            ApartmentTkocontainers = new HashSet<ApartmentTkocontainer>();
        }

        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string Description { get; set; }
        public int CallsCount { get; set; }
        public int PeriodicityId { get; set; }
        public long? LocalityId { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool? IsTko { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual LocalAddress Locality { get; set; }
        public virtual FasetItem Periodicity { get; set; }
        public virtual ICollection<ApartmentTkocontainer> ApartmentTkocontainers { get; set; }
    }
}
