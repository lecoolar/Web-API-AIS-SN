using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentPersonBenefitsView
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public long ApartmentId { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public string PersonName { get; set; }
        public DateTime? BirthDate { get; set; }
        public long BenefitId { get; set; }
        public string BenefitName { get; set; }
    }
}
