using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitArea
    {
        public long Id { get; set; }
        public long BenefitId { get; set; }
        public long BenefitSrvTypeId { get; set; }
        public decimal Percent { get; set; }
        public decimal? Sum { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public int FamilyFasetId { get; set; }
        public int? ExceptApartmentTypeId { get; set; }
        public decimal? AdditionalSquareFactor { get; set; }
        public int? BenefitNormUseTypeId { get; set; }
        public int UseApartmentOwnerShare { get; set; }
        public int UseAllSquare { get; set; }
        public int UseFamilySquare { get; set; }
        public int UsePersonSquare { get; set; }
        public DateTime? MonetizationDate { get; set; }
        public bool? IsMonetization { get; set; }
        public byte Priority { get; set; }
        public int? BenefitAggregationTypeid { get; set; }
        public int UseAllSquareSumm { get; set; }
        public bool? IsSave { get; set; }
        public bool? CanExceedNorm { get; set; }
        public DateTime? Datee { get; set; }
        public bool? IsLimitBenefitNorm { get; set; }
        public bool? UseNormToAloneBenefitOwner { get; set; }

        public virtual Benefit1 Benefit { get; set; }
        public virtual FasetItem BenefitAggregationType { get; set; }
        public virtual FasetItem BenefitNormUseType { get; set; }
        public virtual BenefitServiceType BenefitSrvType { get; set; }
        public virtual FasetItem ExceptApartmentType { get; set; }
        public virtual FasetItem FamilyFaset { get; set; }
    }
}
