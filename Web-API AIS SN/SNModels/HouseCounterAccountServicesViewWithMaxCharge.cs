using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterAccountServicesViewWithMaxCharge
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long? HouseCounterId { get; set; }
        public long AccountServiceId { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? ResidentsCountForDay { get; set; }
        public decimal? ResourcesVolume { get; set; }
        public decimal? CountersVolume { get; set; }
        public decimal? HouseSquare { get; set; }
        public decimal? HouseResidentsCount { get; set; }
        public decimal? CoefficientDays { get; set; }
        public decimal CoefficientCalc { get; set; }
        public decimal? RateForDay { get; set; }
        public decimal? NormRateForDay { get; set; }
        public decimal? SquareForDay { get; set; }
        public decimal? DeltaForDay { get; set; }
        public decimal? InfoPrintDeltaForDay { get; set; }
        public decimal? InfoNormDeltaForDay { get; set; }
        public decimal? NoncoreHouseSquare { get; set; }
        public decimal? NonResidentialConsumptions { get; set; }
        public int? BranchCalc { get; set; }
    }
}
