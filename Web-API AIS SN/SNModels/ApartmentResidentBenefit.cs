using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentBenefit
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long PersonId { get; set; }
        public long PersonBenefitId { get; set; }
        public long ServiceTypeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string CloseReason { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual Person Person { get; set; }
        public virtual PersonBenefit PersonBenefit { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
