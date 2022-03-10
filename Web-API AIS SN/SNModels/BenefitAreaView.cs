using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitAreaView
    {
        public long Id { get; set; }
        public long BenefitId { get; set; }
        public string BenefitName { get; set; }
        public long BenefitSrvTypeId { get; set; }
        public string BenefitSrvTypeName { get; set; }
        public decimal Percent { get; set; }
        public decimal? Sum { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public int FamilyFasetId { get; set; }
        public string FasetName { get; set; }
        public long OrgId { get; set; }
        public string OrgName { get; set; }
        public int? ExceptApartmentTypeId { get; set; }
        public string ExceptApartmentTypeName { get; set; }
        public decimal? AdditionalSquareFactor { get; set; }
        public int? BenefitNormUseTypeId { get; set; }
        public string BenefitNormUseTypeName { get; set; }
        public int UseApartmentOwnerShare { get; set; }
        public int UseAllSquare { get; set; }
        public int UsePersonSquare { get; set; }
        public int UseFamilySquare { get; set; }
        public DateTime? MonetizationDate { get; set; }
        public bool IsMonetization { get; set; }
        public byte Priority { get; set; }
        public int? BenefitAggregationTypeId { get; set; }
        public string BenefitAggregationTypeName { get; set; }
        public int UseAllSquareSumm { get; set; }
        public bool IsSave { get; set; }
        public bool? CanExceedNorm { get; set; }
        public DateTime? Datee { get; set; }
        public bool? IsLimitBenefitNorm { get; set; }
        public bool UseNormToAloneBenefitOwner { get; set; }
    }
}
