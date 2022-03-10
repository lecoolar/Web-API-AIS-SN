using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitLaw
    {
        public long Id { get; set; }
        public long BenefitId { get; set; }
        public long LawId { get; set; }

        public virtual Benefit1 Benefit { get; set; }
        public virtual Law Law { get; set; }
    }
}
