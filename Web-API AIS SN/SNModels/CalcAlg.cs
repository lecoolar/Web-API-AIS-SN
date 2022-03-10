using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcAlg
    {
        public CalcAlg()
        {
            CalcAlgWithOdnbyNormLinkCalcAlgNorms = new HashSet<CalcAlgWithOdnbyNormLink>();
            CalcAlgWithOdnbyNormLinkCalcAlgs = new HashSet<CalcAlgWithOdnbyNormLink>();
            GroupOperCalcCounterParams = new HashSet<GroupOperCalcCounterParam>();
            GroupOperCalcHouseCounterParam1s = new HashSet<GroupOperCalcHouseCounterParam1>();
            GroupOperCalcHouseCounterParams = new HashSet<GroupOperCalcHouseCounterParam>();
            GroupOperCalcParam1s = new HashSet<GroupOperCalcParam1>();
            Service1s = new HashSet<Service1>();
            ServiceCalcAlgs = new HashSet<ServiceCalcAlg>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long ChargeFormulaId { get; set; }
        public byte NeedBenefitCalc { get; set; }
        public long? BenefitNormFormulaId { get; set; }
        public int? ParamFasetItemId { get; set; }
        public byte UseVacationsInBenefits { get; set; }
        public byte UseResidentBenefitShare { get; set; }
        public byte? UseOwnershipShareInBenefits { get; set; }
        public byte MonthShift { get; set; }
        public bool? UseSuspensionFactor { get; set; }
        public bool? IsRecalcWithUseResidentVacations { get; set; }
        public int? CalcPriority { get; set; }
        public bool? NeedSaveCalc { get; set; }
        public bool? NeedSaveJnParams { get; set; }
        public bool IsMin1Resident { get; set; }
        public long? ChargeNormFormulaId { get; set; }
        public bool? UseSeasonalFactor { get; set; }
        public bool? UseCounterTypeForLastYear { get; set; }
        public bool? UseOwnersInCalcAvg { get; set; }

        public virtual CalcAlgorithmBenefitNormFormula BenefitNormFormula { get; set; }
        public virtual CalcAlgorithmChargeFormula ChargeFormula { get; set; }
        public virtual CalcAlgorithmChargeFormula ChargeNormFormula { get; set; }
        public virtual FasetItem ParamFasetItem { get; set; }
        public virtual ICollection<CalcAlgWithOdnbyNormLink> CalcAlgWithOdnbyNormLinkCalcAlgNorms { get; set; }
        public virtual ICollection<CalcAlgWithOdnbyNormLink> CalcAlgWithOdnbyNormLinkCalcAlgs { get; set; }
        public virtual ICollection<GroupOperCalcCounterParam> GroupOperCalcCounterParams { get; set; }
        public virtual ICollection<GroupOperCalcHouseCounterParam1> GroupOperCalcHouseCounterParam1s { get; set; }
        public virtual ICollection<GroupOperCalcHouseCounterParam> GroupOperCalcHouseCounterParams { get; set; }
        public virtual ICollection<GroupOperCalcParam1> GroupOperCalcParam1s { get; set; }
        public virtual ICollection<Service1> Service1s { get; set; }
        public virtual ICollection<ServiceCalcAlg> ServiceCalcAlgs { get; set; }
    }
}
