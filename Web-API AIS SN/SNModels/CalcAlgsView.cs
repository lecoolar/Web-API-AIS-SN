using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcAlgsView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ChargeFormulaId { get; set; }
        public string ChargeFormulaName { get; set; }
        public string ChargeFormulaFormula { get; set; }
        public string ChargeProcName { get; set; }
        public long? BenefitNormFormulaId { get; set; }
        public string BenefitNormFormulaName { get; set; }
        public string BenefitNormFormulaFormula { get; set; }
        public int? ParamFasetItemId { get; set; }
        public string ParamFasetItemName { get; set; }
        public byte NeedBenefitCalc { get; set; }
        public byte UseVacationsInBenefits { get; set; }
        public byte UseResidentBenefitShare { get; set; }
        public byte? UseOwnershipShareInBenefits { get; set; }
        public byte MonthShift { get; set; }
        public bool? UseSuspensionFactor { get; set; }
        public bool IsRecalcWithUseResidentVacations { get; set; }
        public int? CalcPriority { get; set; }
    }
}
