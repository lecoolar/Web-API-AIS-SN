using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonBenefit
    {
        public PersonBenefit()
        {
            ApartmentResidentBenefits = new HashSet<ApartmentResidentBenefit>();
            PersonBenefitDocuments = new HashSet<PersonBenefitDocument>();
        }

        public long Id { get; set; }
        public long PersonId { get; set; }
        public long BenefitId { get; set; }
        public DateTime Datec { get; set; }

        public virtual Benefit1 Benefit { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<ApartmentResidentBenefit> ApartmentResidentBenefits { get; set; }
        public virtual ICollection<PersonBenefitDocument> PersonBenefitDocuments { get; set; }
    }
}
