using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResident
    {
        public ApartmentResident()
        {
            ApartmentRequests = new HashSet<ApartmentRequest>();
            ApartmentResidentBenefitProperties = new HashSet<ApartmentResidentBenefitProperty>();
            ApartmentResidentVacations = new HashSet<ApartmentResidentVacation>();
        }

        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long PersonId { get; set; }
        public int? TypeResidents { get; set; }
        public int? Relative { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public string Comment { get; set; }
        public DateTime? DateChange { get; set; }
        public short IsTransferedPasport { get; set; }
        public long? UserId { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual Person Person { get; set; }
        public virtual FasetItem RelativeNavigation { get; set; }
        public virtual FasetItem TypeResidentsNavigation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequests { get; set; }
        public virtual ICollection<ApartmentResidentBenefitProperty> ApartmentResidentBenefitProperties { get; set; }
        public virtual ICollection<ApartmentResidentVacation> ApartmentResidentVacations { get; set; }
    }
}
