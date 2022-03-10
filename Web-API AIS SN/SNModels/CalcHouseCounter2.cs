using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounter2
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long CalcId { get; set; }
        public long AlgorithmId { get; set; }
        public long HouseId { get; set; }
        public long HouseCounterId { get; set; }
        public DateTime Period { get; set; }
        public DateTime ParamsPeriod { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public decimal? HouseCounterVolume { get; set; }
        public decimal? PersonalCountersVolume { get; set; }
        public decimal? NormativeVolume { get; set; }
        public decimal? FactorForPersonalCounters { get; set; }
        public decimal? FactorForSixFormula { get; set; }
    }
}
