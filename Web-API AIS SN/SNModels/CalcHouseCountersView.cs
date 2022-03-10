using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCountersView
    {
        public long Id { get; set; }
        public long CalcId { get; set; }
        public long AlgorithmId { get; set; }
        public long HouseCounterId { get; set; }
        public decimal? HouseCounterVolume { get; set; }
        public long HouseId { get; set; }
        public decimal? NormativeVolume { get; set; }
        public DateTime Period { get; set; }
        public DateTime ParamsPeriod { get; set; }
        public DateTime PeriodEnd { get; set; }
        public DateTime PeriodStart { get; set; }
        public decimal? PersonalCountersVolume { get; set; }
        public decimal? CalcTime { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
    }
}
