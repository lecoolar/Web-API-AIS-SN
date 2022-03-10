using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcAlgorithmBenefitNormFormula
    {
        public CalcAlgorithmBenefitNormFormula()
        {
            CalcAlgs = new HashSet<CalcAlg>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Formula { get; set; }
        public string ProcName { get; set; }
        public byte? NeedSquareNorm { get; set; }
        public byte? NeedWaterNorm { get; set; }
        public byte? NeedGasNorm { get; set; }
        public byte? NeedElectricNorm { get; set; }

        public virtual ICollection<CalcAlg> CalcAlgs { get; set; }
    }
}
