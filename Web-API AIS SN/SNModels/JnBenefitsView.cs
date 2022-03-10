using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnBenefitsView
    {
        public long Id { get; set; }
        public long JnId { get; set; }
        public long BenefitId { get; set; }
        public string BenefitLongName { get; set; }
        public long BenefitOwnerId { get; set; }
        public string BenefitOwnerName { get; set; }
        public long? ExploitingPersonId { get; set; }
        public string ExploutingPersonName { get; set; }
        public decimal Summ { get; set; }
    }
}
