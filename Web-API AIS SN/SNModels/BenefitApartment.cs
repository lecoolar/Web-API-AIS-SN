using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitApartment
    {
        public BenefitApartment()
        {
            JnBenefits = new HashSet<JnBenefit>();
        }

        public long Id { get; set; }
        public long? PersonId { get; set; }
        public long? ApartmentId { get; set; }
        public DateTime Period { get; set; }
        public long? AccountBenefit { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public Guid? Guid { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<JnBenefit> JnBenefits { get; set; }
    }
}
