using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServiceBenefit1
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long CalcId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public long? BenefitId { get; set; }
        public long BenefitOwnerId { get; set; }
        public decimal BenefitSumm { get; set; }
        public long ExploitingPersonId { get; set; }
        public DateTime? MonetizationDate { get; set; }
        public bool? IsMonetization { get; set; }
        public bool IsSave { get; set; }
    }
}
