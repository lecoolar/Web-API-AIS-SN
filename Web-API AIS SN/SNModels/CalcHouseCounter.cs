using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounter
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long CalcId { get; set; }
        public DateTime Period { get; set; }
        public long HouseCounterId { get; set; }
        public bool? IsNotInternal { get; set; }
        public decimal? Indication { get; set; }
        public DateTime? IndicationDate { get; set; }
        public decimal? IndicationPrev { get; set; }
        public DateTime? IndicationDatePrev { get; set; }
        public decimal? Consumption { get; set; }
        public decimal? SubCountersVolume { get; set; }
        public decimal? NonResidentialConsumptions { get; set; }
        public decimal? CountersVolume { get; set; }
        public decimal? ResourcesVolume { get; set; }
        public decimal? Coefficient { get; set; }
        public decimal? Delta { get; set; }
        public decimal? HouseSquare { get; set; }
        public decimal? TotalResidentsCount { get; set; }
        public decimal? HouseSquareLiving { get; set; }
        public decimal? HouseSquareNotLiving { get; set; }
        public decimal? AdditionallyVolume { get; set; }
        public decimal? HouseShare { get; set; }
        public decimal? HouseRecalcVolume { get; set; }
        public decimal? HouseNormRateOdn { get; set; }
        public decimal? HouseSquareOi { get; set; }
        public decimal? HouseTotalSquareApartments { get; set; }
        public decimal? RecalcsVolume { get; set; }
        public decimal? NonResidentialResourceVolume { get; set; }
        public decimal? NonResidentialCountersVolume { get; set; }
        public decimal? CountersVolumeF03 { get; set; }
        public decimal? ResourcesVolumeF03 { get; set; }
    }
}
