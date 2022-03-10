using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounterService1
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long? CalcId { get; set; }
        public long? AlgorithmId { get; set; }
        public long? HouseCounterId { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceTypeId { get; set; }
        public decimal? CounterConsumption { get; set; }
        public DateTime? RangeStart { get; set; }
        public DateTime? RangeEnd { get; set; }
        public decimal? ResourceVolume { get; set; }
        public decimal? CountersVolume { get; set; }
        public decimal? HouseSquare { get; set; }
        public bool? IsNorm { get; set; }
        public DateTime? Period { get; set; }
        public decimal? NormativCharge { get; set; }
        public decimal? CounterCharge { get; set; }
        public decimal? HouseCounterCharge { get; set; }
        public int? DaysInRange { get; set; }
        public int? DaysInPeriod { get; set; }
        public long? AdrId { get; set; }
        public decimal? NonResidentialsVolume { get; set; }
        public decimal? SubCountersVolume { get; set; }
        public bool? IsNotInternal { get; set; }
        public decimal? Coefficient { get; set; }
        public decimal? Delta { get; set; }
        public decimal? TotalSquareApartments { get; set; }
        public decimal? CalcSquare { get; set; }
        public decimal? TotalResidentsCount { get; set; }
        public decimal? HouseSquareLiving { get; set; }
        public decimal? HouseSquareNotLiving { get; set; }
        public decimal? RecalcVolume { get; set; }
        public decimal? RecalcSumm { get; set; }
        public long? HouseCounterServiceId { get; set; }
        public string VolumeType { get; set; }
        public decimal? NormRateOdn { get; set; }
        public decimal? SquareOi { get; set; }
        public decimal? Share { get; set; }
        public string CounterNumber { get; set; }
        public decimal? CounterConsumptionGiga { get; set; }
        public decimal? ResidentsCount { get; set; }
        public decimal? NonResidentialResourceVolume { get; set; }
        public decimal? NonResidentialCountersVolume { get; set; }
        public decimal? NormRateOdnSum { get; set; }
        public decimal? NormOdn { get; set; }
        public decimal? ApartmentCounterAdditionalVolume { get; set; }
        public decimal? ApartmentNormativeAdditionalVolume { get; set; }
        public decimal? ResourceHeatVolume { get; set; }
        public decimal? CountersHeatVolume { get; set; }
        public decimal? ResourceGvsM3volume { get; set; }
        public decimal? CountersGvsM3volume { get; set; }
    }
}
