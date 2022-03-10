using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnBenefit
    {
        public long Id { get; set; }
        public long BenefitApartmentId { get; set; }
        public string ServiceName { get; set; }
        public long? ServiceId { get; set; }
        public decimal Edk { get; set; }

        public virtual BenefitApartment BenefitApartment { get; set; }
        public virtual Service1 Service { get; set; }
    }
}
