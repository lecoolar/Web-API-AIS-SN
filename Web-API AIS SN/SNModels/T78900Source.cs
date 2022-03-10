using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T78900Source
    {
        public string Address { get; set; }
        public double? PercentAffected { get; set; }
        public double? PercentAffected2 { get; set; }
        public double? ItogPercentAffected { get; set; }
    }
}
