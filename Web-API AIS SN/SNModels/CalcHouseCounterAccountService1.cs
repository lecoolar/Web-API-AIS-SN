using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounterAccountService1
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? CalcId { get; set; }
        public DateTime Period { get; set; }
        public long? HouseCounterId { get; set; }
        public long AccountServiceId { get; set; }
        public decimal? Delta { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? NormRate { get; set; }
        public decimal? Square { get; set; }
        public decimal? ResidentsCount { get; set; }
        public decimal? ResidentsCountForDay { get; set; }
        public decimal? ResourcesVolume { get; set; }
        public decimal? CountersVolume { get; set; }
        public decimal? HouseSquare { get; set; }
        public decimal? HouseResidentsCount { get; set; }
        public decimal? CoefficientDays { get; set; }
        public decimal CoefficientCalc { get; set; }
        public decimal? Infoprintdelta { get; set; }
        public decimal? RateForDay { get; set; }
        public decimal? NormRateForDay { get; set; }
        public decimal? SquareForDay { get; set; }
        public decimal? DeltaForDay { get; set; }
        public decimal? InfoPrintDeltaForDay { get; set; }
        public decimal? InfoNormDeltaForDay { get; set; }
        public decimal? NoncoreHouseSquare { get; set; }
        public decimal? NonResidentialConsumptions { get; set; }
        public int? BranchCalc { get; set; }
        public decimal? HouseDelta { get; set; }
        public decimal? HouseCounterConsumption { get; set; }
        public decimal? ApartmentResourceVolume { get; set; }
        public decimal? ApartmentCounterVolume { get; set; }
        public decimal? ApartmentNonResidentialConsumption { get; set; }
        public decimal? RecalcsVolume { get; set; }
        public decimal? NonResidentialResourceVolume { get; set; }
        public decimal? NonResidentialCountersVolume { get; set; }
        public decimal? ApartmentNonResidentialResourceVolume { get; set; }
        public decimal? ApartmentNonResidentialCounterVolume { get; set; }
        public decimal? NormSocial { get; set; }
        public decimal? BigRateForDay { get; set; }
        public decimal? BigDeltaForDay { get; set; }
        public decimal? InfoHouseConsumptionGiga { get; set; }
        public decimal? InfoHouseConsumptionVolume { get; set; }
        public decimal? InfoHouseRateGiga { get; set; }
        public decimal? SubCountersVolume { get; set; }
        public decimal? HouseHeatSquare { get; set; }
        public decimal? HouseHeatCounterSquare { get; set; }
        public decimal? HouseHeatCounterVolume { get; set; }
        public decimal? TotalApartmentVolume { get; set; }
        public decimal? ApartmentVolume { get; set; }
        public decimal? ApartmentOdpuVolume { get; set; }
        public decimal? ResourceHeatVolume { get; set; }
        public decimal? CountersHeatVolume { get; set; }
        public decimal? ResourceGvsM3volume { get; set; }
        public decimal? CountersGvsM3volume { get; set; }
        public int? IsHouseValInfo { get; set; }
        public decimal? DeltaFromLastPeriod { get; set; }
    }
}
