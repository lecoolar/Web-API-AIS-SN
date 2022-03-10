using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServiceBenefitsByDay2
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long CalcId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public DateTime RangeStart { get; set; }
        public long BenefitOwnerId { get; set; }
        public long ExploitingPersonId { get; set; }
        public byte? DaysInRange { get; set; }
        public byte? DaysInPeriod { get; set; }
        public long? AlgorithmId { get; set; }
        public int? AlgorithmParamId { get; set; }
        public byte? UseVacationsInBenefits { get; set; }
        public byte? UseResidentBenefitShare { get; set; }
        public string Formula { get; set; }
        public string ProcName { get; set; }
        public byte? NeedSquareNorm { get; set; }
        public byte? NeedWaterNorm { get; set; }
        public byte? NeedGasNorm { get; set; }
        public byte? NeedElectricNorm { get; set; }
        public long? BenefitId { get; set; }
        public string BenefitCalcType { get; set; }
        public string BenefitAreaCalcType { get; set; }
        public long? ServiceTypeId { get; set; }
        public string ServiceType { get; set; }
        public long? ServiceTypeSynonymId { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? RateForDay { get; set; }
        public long? ApartmentId { get; set; }
        public decimal? TotalSquare { get; set; }
        public decimal? LivingSquare { get; set; }
        public decimal? HeatingSquare { get; set; }
        public decimal? BalconySquare { get; set; }
        public string ApartmentType { get; set; }
        public int? ResidentsCount { get; set; }
        public int? ResidentVacationsCount { get; set; }
        public int? TotalResidentsCount { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? NormSumm { get; set; }
        public decimal? BenefitSumm { get; set; }
        public decimal? GasNorm { get; set; }
        public decimal? ElectricNorm { get; set; }
        public decimal? WaterNorm { get; set; }
        public decimal? SquareNorm { get; set; }
        public decimal? SquareAdd { get; set; }
        public int? UsePersonSquare { get; set; }
        public int? UseFamilySquare { get; set; }
        public int? UseApartmentOwnerShare { get; set; }
        public long? CounterId { get; set; }
        public decimal? CounterFactor { get; set; }
        public decimal? SuspensionFactor { get; set; }
        public long? AccountId { get; set; }
        public decimal? NormRate { get; set; }
        public decimal? NormRateForDay { get; set; }
        public string BenefitNormUseTypeName { get; set; }
        public decimal? RateCounter { get; set; }
        public decimal? RateCounterForDay { get; set; }
        public decimal? HouseNorm { get; set; }
        public decimal? BenefitMaxNorm { get; set; }
        public string UiFormula { get; set; }
        public int? ApartmentTypeId { get; set; }
        public bool? IsWithCooker { get; set; }
        public int? ExceptApartmentTypeId { get; set; }
        public byte? Priority { get; set; }
        public int? BenefitAggregationTypeid { get; set; }
        public int? UseAllSquareSumm { get; set; }
        public bool? CanExceedNorm { get; set; }
        public bool? IsLimitBenefitNorm { get; set; }
    }
}
