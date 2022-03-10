using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NonresidentialApartment
    {
        public NonresidentialApartment()
        {
            HouseCounterNonresidentialApartmentConsumptions = new HashSet<HouseCounterNonresidentialApartmentConsumption>();
            NonresidentialApartmentHouseCounters = new HashSet<NonresidentialApartmentHouseCounter>();
            NonresidentialApartmentProperties = new HashSet<NonresidentialApartmentProperty>();
        }

        public long Id { get; set; }
        public long HouseId { get; set; }
        public long OwnerId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string Number { get; set; }
        public long? ApartmentId { get; set; }

        public virtual House House { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual ICollection<HouseCounterNonresidentialApartmentConsumption> HouseCounterNonresidentialApartmentConsumptions { get; set; }
        public virtual ICollection<NonresidentialApartmentHouseCounter> NonresidentialApartmentHouseCounters { get; set; }
        public virtual ICollection<NonresidentialApartmentProperty> NonresidentialApartmentProperties { get; set; }
    }
}
