using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnBenefitAccount
    {
        public long Id { get; set; }
        public long BenefitAccountId { get; set; }
        public string ServiceTypeName { get; set; }
        public long? ServiceTypeId { get; set; }
        public decimal Edk { get; set; }

        public virtual BenefitAccount BenefitAccount { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
