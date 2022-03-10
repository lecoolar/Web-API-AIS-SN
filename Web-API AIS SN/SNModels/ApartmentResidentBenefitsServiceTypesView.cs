using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentBenefitsServiceTypesView
    {
        public long BenefitId { get; set; }
        public string BenefitName { get; set; }
        public decimal BenefitPercent { get; set; }
        public int FamilyFasetId { get; set; }
        public string FamilyFasetName { get; set; }
        public DateTime FromDate { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public long BenefitServiceTypeId { get; set; }
        public string BenefitServiceTypeName { get; set; }
        public int? IsOwnerBenefit { get; set; }
    }
}
