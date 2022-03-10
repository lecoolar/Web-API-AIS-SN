using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TempRecalc
    {
        public long GroupOperId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public decimal? ResourceDelta { get; set; }
        public decimal? CounterConsumptionDelta { get; set; }
        public decimal? NormConsumptionDelta { get; set; }
        public decimal? AvgConsumptionDelta { get; set; }
    }
}
