using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TmpCounterJune
    {
        public long? AccountServiceId { get; set; }
        public long? CounterId { get; set; }
        public DateTime? Period { get; set; }
        public DateTime? EndPeriod { get; set; }
        public long? AccountId { get; set; }
        public long? ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public decimal? ApartmentTotalSquare { get; set; }
        public decimal? ApartmentHeatingSquare { get; set; }
        public bool? ApartmentIsNonResidential { get; set; }
        public long? HouseId { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceTypeId { get; set; }
        public decimal? ResidentsCount { get; set; }
        public decimal? NormRate { get; set; }
        public long? ServiceNormId { get; set; }
        public DateTime? LastDate { get; set; }
        public decimal? LastInd { get; set; }
        public decimal? LastIndRevert { get; set; }
        public decimal? NewInd { get; set; }
        public decimal? NewIndRevert { get; set; }
        public bool? IsByCounter { get; set; }
        public decimal? AvgConsumption { get; set; }
        public decimal? AvgConsumptionRevert { get; set; }
        public decimal? CounterFactor { get; set; }
        public bool? UseOwners { get; set; }
        public bool? NotUseMonthCloseCounter { get; set; }
        public DateTime? ValDate { get; set; }
    }
}
