using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupOperCalcParam
    {
        public long Id { get; set; }
        public long GroupOperId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
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
        public decimal? NormRate { get; set; }
        public int UseNormRate { get; set; }
        public decimal? ResidentsCountInfo { get; set; }
        public decimal? ResidentVacationsCountInfo { get; set; }
        public decimal? TotalSquareInfo { get; set; }
        public decimal? SuspensionFactorNorm { get; set; }
        public decimal? SuspensionFactorCounter { get; set; }
        public decimal? ResidentsCount { get; set; }
        public decimal? ResidentsCountNorm { get; set; }
        public decimal? ResidentsCountCounter { get; set; }
        public decimal? ResidentVacationsCount { get; set; }
        public decimal? ResidentsCountAvg { get; set; }
        public decimal? SubQualityFactorNorm { get; set; }
        public long? CalcAlgsId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? CreatedPeriod { get; set; }
    }
}
