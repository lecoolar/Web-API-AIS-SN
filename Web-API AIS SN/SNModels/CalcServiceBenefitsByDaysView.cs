using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServiceBenefitsByDaysView
    {
        public long Id { get; set; }
        public long CalcId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public int? ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public DateTime RangeStart { get; set; }
        public long BenefitOwnerId { get; set; }
        public string PersonName { get; set; }
        public string BenefitCode { get; set; }
        public string BenefitShortName { get; set; }
        public long ExploitingPersonId { get; set; }
        public string ExploitingPersonName { get; set; }
        public byte? DaysInRange { get; set; }
        public byte? DaysInPeriod { get; set; }
        public long? AlgorithmId { get; set; }
        public string CalcAlgBenefitNormFormulaName { get; set; }
        public string CalcAlgBenefitNormFormula { get; set; }
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
        public long? CounterId { get; set; }
        public int? IsCounter { get; set; }
        public decimal? CounterFactor { get; set; }
        public decimal? SuspensionFactor { get; set; }
        public string UiFormula { get; set; }
    }
}
