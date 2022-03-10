using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupOperCalcParamUiFormula
    {
        public long GroupOperId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public DateTime RangeStart { get; set; }
        public string UiFormula { get; set; }
    }
}
