using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServicesByDaysViewForLk
    {
        public long? Id { get; set; }
        public long? CalcId { get; set; }
        public long? AccountServiceId { get; set; }
        public long? AccountId { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public DateTime? Period { get; set; }
        public DateTime? ParamsPeriod { get; set; }
        public DateTime? RangeStart { get; set; }
        public DateTime? RangeEnd { get; set; }
        public byte? DaysInRange { get; set; }
        public string RangeStartReason { get; set; }
        public byte? DaysInPeriod { get; set; }
        public DateTime? FromDate { get; set; }
        public long? ToDate { get; set; }
        public long? AlgorithmId { get; set; }
        public string CalcAlgsName { get; set; }
        public string CalcAlgChargeFormulaName { get; set; }
        public string CalcAlgChargeFormula { get; set; }
        public long? AlgorithmParamId { get; set; }
        public string AlgorithmParamName { get; set; }
        public string Formula { get; set; }
        public string ProcName { get; set; }
        public byte? NeedApartmentSquares { get; set; }
        public byte? NeedHousekeepingSquares { get; set; }
        public byte? NeedApartmentProperties { get; set; }
        public byte? NeedCounters { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? Rate { get; set; }
        public decimal? RateForDay { get; set; }
        public long? HouseId { get; set; }
        public long? HouseFloor { get; set; }
        public long? ApartmentId { get; set; }
        public long? Floor { get; set; }
        public long? RoomsCount { get; set; }
        public decimal? TotalSquare { get; set; }
        public decimal? LivingSquare { get; set; }
        public decimal? HeatingSquare { get; set; }
        public decimal? BalconySquare { get; set; }
        public long? ResidentsCount { get; set; }
        public long? ResidentVacationsCount { get; set; }
        public long? TotalResidentsCount { get; set; }
        public decimal? HousekeepingSquare { get; set; }
        public long? ApartmentProperty { get; set; }
        public long? CounterId { get; set; }
        public long? IsCounter { get; set; }
        public decimal? CounterPaymentShare { get; set; }
        public string CounterMaddleType { get; set; }
        public long? CounterTurnoverSize { get; set; }
        public decimal? CounterConsumption { get; set; }
        public decimal? NormConsumption { get; set; }
        public decimal? CounterInternalFactor { get; set; }
        public decimal? CounterExternalFactor { get; set; }
        public decimal? SuspensionFactor { get; set; }
        public bool? IsSixthFormula { get; set; }
        public decimal? SubQualityHoursCount { get; set; }
        public decimal? SubQualityHoursCountCalcedByColdWaterTarif { get; set; }
        public decimal? SubstitutionTarif { get; set; }
        public decimal? SubQualityChargeSumm { get; set; }
        public decimal? PeriodChargeSumm { get; set; }
        public decimal? PeriodCounterConsumption { get; set; }
        public string UiFormula { get; set; }
        public decimal? CounterConsumptionSumm { get; set; }
        public decimal? NormConsumptionSumm { get; set; }
        public decimal? ResidentsCountCounter { get; set; }
        public decimal? ResidentsCountNorm { get; set; }
        public decimal? ResidentsCountAvg { get; set; }
    }
}
