using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Calc
    {
        public long CalcId { get; set; }
        public int? TryCount { get; set; }
        public string ErrorText { get; set; }
    }
}
