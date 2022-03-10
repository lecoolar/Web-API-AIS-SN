using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentBenefitProperty
    {
        public long Id { get; set; }
        public long ApartmentResidentId { get; set; }
        public int Kind { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public long? BankId { get; set; }

        public virtual ApartmentResident ApartmentResident { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual FasetItem KindNavigation { get; set; }
    }
}
