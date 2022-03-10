using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcAlgorithm
    {
        public long Id { get; set; }
        public int? TypeFaset { get; set; }
        public string SubTypeName { get; set; }
        public int? DefaultTariffFaset { get; set; }
        public int? ParamFasetId { get; set; }
        public int? ParamFasetItemId { get; set; }
        public int? CalcPriority { get; set; }

        public virtual FasetItem DefaultTariffFasetNavigation { get; set; }
        public virtual FasetItem ParamFasetItem { get; set; }
        public virtual FasetItem TypeFasetNavigation { get; set; }
    }
}
