using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnCalcParam
    {
        public long Id { get; set; }
        public long JnId { get; set; }
        public DateTime RangeStart { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? SuspensionFactor { get; set; }
        public decimal? SubQualityFactor { get; set; }
        public decimal? CoefficientDays { get; set; }
        public decimal? CounterConsumption { get; set; }
        public decimal? CounterConsumptionDelta { get; set; }
        public decimal? NormConsumption { get; set; }
        public decimal? NormConsumptionDelta { get; set; }
        public decimal? AvgConsumption { get; set; }
        public decimal? AvgConsumptionDelta { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Resource { get; set; }
        public int? ResourceUnitId { get; set; }
        public decimal? ResourceDelta { get; set; }
        public decimal? RateGeneral { get; set; }
        public decimal? ResourceGeneral { get; set; }
        public int? ResourceGeneralUnitId { get; set; }
        public decimal? ResourceGeneralDelta { get; set; }
        public decimal? ResourceAltGeneral { get; set; }
        public decimal? ResourceAltGeneralDelta { get; set; }
        public decimal? NormRate { get; set; }
        public bool UseNormRate { get; set; }
        public decimal? ResidentsCountInfo { get; set; }
        public decimal? ResidentVacationsCountInfo { get; set; }
        public decimal? TotalSquareInfo { get; set; }
        public decimal? SuspensionFactorNorm { get; set; }
        public decimal SuspensionFactorCounter { get; set; }
        public decimal? SubQualityFactorNorm { get; set; }
        public decimal? RateGeneral2 { get; set; }
        public decimal? ResourceGeneral2 { get; set; }
        public int? ResourceGeneral2UnitId { get; set; }
        public decimal? ResourceGeneral2Delta { get; set; }

        public virtual Jn1 Jn { get; set; }
    }
}
