using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSubQualityAcceptableDurationsView
    {
        public long Id { get; set; }
        public long ServiceTypeSubQualityId { get; set; }
        public string ServiceTypeName { get; set; }
        public string QualityName { get; set; }
        public string QualityTypeName { get; set; }
        public int? HoursAtOnce { get; set; }
        public int? HoursTotal { get; set; }
        public int? HoursTotalYear { get; set; }
        public decimal? NightTimeStart { get; set; }
        public decimal? NightTimeEnd { get; set; }
        public decimal? TemperatureStart { get; set; }
        public decimal? TemperatureEnd { get; set; }
        public decimal? NightTemperatureAcceptableDifference { get; set; }
        public decimal? DayTemperatureAcceptableDifference { get; set; }
        public decimal? OverTemperatureAcceptable { get; set; }
        public decimal? PressureStart { get; set; }
        public decimal? PressureEnd { get; set; }
        public decimal? PressureAcceptableDifference { get; set; }
        public string Comment { get; set; }
        public string AcceptableDurationName { get; set; }
    }
}
