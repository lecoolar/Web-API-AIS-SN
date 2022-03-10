using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServiceTypeSubQualityByDay2
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long CalcServiceTypeSubQualityId { get; set; }
        public DateTime RangeStart { get; set; }
        public DateTime RangeEnd { get; set; }
        public byte DaysInRange { get; set; }
        public decimal HoursCount { get; set; }
        public long? StsqpId { get; set; }
        public long? StsqadId { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeNameAlias { get; set; }
        public string QualityTypeName { get; set; }
        public decimal? HoursAtOnce { get; set; }
        public decimal? HoursTotal { get; set; }
        public decimal? SquareRooms { get; set; }
        public decimal? NightTemperature { get; set; }
        public decimal? DayTemperature { get; set; }
        public decimal? PressureDeviation { get; set; }
        public decimal? NightSubQualityHoursCount { get; set; }
        public decimal? DaySubQualityHoursCount { get; set; }
        public decimal? SubQualityHoursCount { get; set; }
        public decimal? CalculatedNightRangePercent { get; set; }
        public decimal? CalculatedDayRangePercent { get; set; }
        public decimal? CalculatedRangePercent { get; set; }
        public decimal? HoursCountCalcedByColdWaterTarif { get; set; }
        public bool IsUninterruptedSupply { get; set; }
        public bool IsPressureEquivalence { get; set; }
        public bool IsPressurePropertiesEquivalence { get; set; }
        public bool IsTemperatureEquivalence { get; set; }
        public bool IsWaterEquivalenceToSanitaryStandard { get; set; }
        public bool IsVoltageAndFrequencyEquivalence { get; set; }
        public bool RecordIsProcessed { get; set; }
        public int? QualityTypeId { get; set; }
        public decimal? NormConsumptionCorrection { get; set; }
        public decimal? ConsumptionRangePercent { get; set; }
        public string UiFormula { get; set; }
        public decimal? NormConsumption { get; set; }
        public int? CalcTypeId { get; set; }
        public bool? IsCounter { get; set; }
        public decimal? HoursTotalYear { get; set; }
        public bool? ExceptAcceptableDuration { get; set; }
    }
}
