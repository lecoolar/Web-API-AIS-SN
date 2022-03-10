using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Benefit1
    {
        public Benefit1()
        {
            BenefitAreas = new HashSet<BenefitArea>();
            BenefitNormsForElectrics = new HashSet<BenefitNormsForElectric>();
            BenefitNormsForGas = new HashSet<BenefitNormsForGa>();
            BenefitNormsForSquares = new HashSet<BenefitNormsForSquare>();
            HouseServiceNormBenefits = new HashSet<HouseServiceNormBenefit>();
            JnBenefit1s = new HashSet<JnBenefit1>();
            PersonBenefits = new HashSet<PersonBenefit>();
            ServiceNormBenefits = new HashSet<ServiceNormBenefit>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int? CalcFeature { get; set; }
        public int? IsAddress { get; set; }
        public decimal? ClLg { get; set; }
        public decimal? ObjLg { get; set; }
        public int? ExternalCode { get; set; }
        public DateTime? MonetizationDate { get; set; }

        public virtual FasetItem CalcFeatureNavigation { get; set; }
        public virtual BenefitLaw BenefitLaw { get; set; }
        public virtual ICollection<BenefitArea> BenefitAreas { get; set; }
        public virtual ICollection<BenefitNormsForElectric> BenefitNormsForElectrics { get; set; }
        public virtual ICollection<BenefitNormsForGa> BenefitNormsForGas { get; set; }
        public virtual ICollection<BenefitNormsForSquare> BenefitNormsForSquares { get; set; }
        public virtual ICollection<HouseServiceNormBenefit> HouseServiceNormBenefits { get; set; }
        public virtual ICollection<JnBenefit1> JnBenefit1s { get; set; }
        public virtual ICollection<PersonBenefit> PersonBenefits { get; set; }
        public virtual ICollection<ServiceNormBenefit> ServiceNormBenefits { get; set; }
    }
}
