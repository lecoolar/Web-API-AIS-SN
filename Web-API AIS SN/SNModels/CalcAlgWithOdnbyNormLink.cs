using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcAlgWithOdnbyNormLink
    {
        public long Id { get; set; }
        public long CalcAlgid { get; set; }
        public long CalcAlgNormid { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual CalcAlg CalcAlg { get; set; }
        public virtual CalcAlg CalcAlgNorm { get; set; }
    }
}
