using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceSubQualityView
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public string AccountNumber { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string ServiceName { get; set; }
        public long StsqpId { get; set; }
        public decimal Percent { get; set; }
        public long ServiceTypeSubQualityId { get; set; }
        public string QualityTypeName { get; set; }
        public int? QualityTypeId { get; set; }
        public long? StsqadId { get; set; }
        public decimal? SquareRooms { get; set; }
        public decimal? NightTemperature { get; set; }
        public decimal? DayTemperature { get; set; }
        public decimal? PressureDeviation { get; set; }
        public int? ReasonId { get; set; }
        public bool? ExceptAcceptableDuration { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Created { get; set; }
        public long GroupOperId { get; set; }
        public long? DocId { get; set; }
        public string DocName { get; set; }
        public int? CalcTypeId { get; set; }
        public string CalcTypeName { get; set; }
    }
}
