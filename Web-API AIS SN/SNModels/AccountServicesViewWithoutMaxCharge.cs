using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicesViewWithoutMaxCharge
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long AccountServiceId { get; set; }
        public long? AlgorithmId { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? Rate { get; set; }
        public decimal? RateForDay { get; set; }
        public decimal? NormRate { get; set; }
        public decimal? NormRateForDay { get; set; }
        public decimal? Square { get; set; }
        public decimal? SquareForDay { get; set; }
        public decimal? ResidentsCount { get; set; }
        public decimal? ResidentsCountForDay { get; set; }
        public decimal? Consumption { get; set; }
        public decimal? SubRate { get; set; }
        public decimal? CoefficientDays { get; set; }
        public decimal? CoefficientUse { get; set; }
        public decimal? CoefficientCalc { get; set; }
        public decimal? CoefficientCalcForDay { get; set; }
        public decimal? Resource { get; set; }
        public decimal? InfoGroupRate { get; set; }
        public decimal? InfoNormRate { get; set; }
        public decimal? InfoHouseRate { get; set; }
        public decimal? InfoHouseNormRate { get; set; }
        public decimal? InfoExistCounter { get; set; }
        public decimal? SuspensionFactor { get; set; }
        public decimal RateCapacity { get; set; }
        public decimal? SocialNormRate { get; set; }
        public decimal? BigRateForDay { get; set; }
        public decimal? AvgConsumptionForDay { get; set; }
        public decimal? InfoCalcNormRate { get; set; }
        public decimal? InfoEnergoServiceResource { get; set; }
        public decimal? InfoHouseConsumptionGiga { get; set; }
        public decimal? InfoHouseConsumptionVolume { get; set; }
        public decimal? InfoHouseRateGiga { get; set; }
        public decimal? InfoHouseResourceGiga { get; set; }
        public decimal? InfoHouseRateNonGiga { get; set; }
        public decimal? InfoHouseResourceNonGiga { get; set; }
        public decimal? NormRateGiga { get; set; }
        public decimal? IncreaseCoefficientK { get; set; }
        public decimal? IncreaseCoefficientResource { get; set; }
        public decimal? IncreaseCoefficientRateByVolume { get; set; }
        public decimal? AnnuityPaymentRefinanceRate { get; set; }
        public decimal? AnnuityPaymentTotalSumm { get; set; }
        public decimal? AnnuityPaymentMonthPercents { get; set; }
        public decimal? ElectroDayRate { get; set; }
        public decimal? ElectroDayResource { get; set; }
        public decimal? ElectroNightResource { get; set; }
        public decimal? ElectroCoeffChargeSumm { get; set; }
        public decimal? ElectroCoefficientK { get; set; }
        public long? AnySubServiceCode { get; set; }
        public decimal? CalcPercentRefinanceRate { get; set; }
        public decimal? CalcPercentSaldo { get; set; }
        public decimal? ViewNormRate { get; set; }
    }
}
