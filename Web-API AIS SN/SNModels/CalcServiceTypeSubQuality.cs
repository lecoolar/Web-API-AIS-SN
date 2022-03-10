using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServiceTypeSubQuality
    {
        public long Id { get; set; }
        public long CalcId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public bool ExceptAcceptableDuration { get; set; }
        public decimal? CalculatedPercentByPeriod { get; set; }
        public decimal? SquareFactorByPeriod { get; set; }
        public decimal? InterruptedSupplyHoursCount { get; set; }
        public int? DayInPeriod { get; set; }
        public decimal? NormConsumptionCorrection { get; set; }
    }
}
