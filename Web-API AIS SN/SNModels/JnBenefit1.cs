using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnBenefit1
    {
        public long Id { get; set; }
        public long JnId { get; set; }
        public long BenefitId { get; set; }
        public long BenefitOwnerId { get; set; }
        public long? ExploitingPersonId { get; set; }
        public decimal Summ { get; set; }

        public virtual Benefit1 Benefit { get; set; }
        public virtual Person BenefitOwner { get; set; }
        public virtual Person ExploitingPerson { get; set; }
        public virtual Jn1 Jn { get; set; }
    }
}
