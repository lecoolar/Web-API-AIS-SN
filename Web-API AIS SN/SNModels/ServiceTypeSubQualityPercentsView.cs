using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSubQualityPercentsView
    {
        public long Id { get; set; }
        public long ServiceTypeSubQualityId { get; set; }
        public string QualityName { get; set; }
        public string QualityTypeName { get; set; }
        public string ServiceTypeName { get; set; }
        public decimal? DeviationStart { get; set; }
        public decimal? DeviationEnd { get; set; }
        public decimal? TemperatureGradationStep { get; set; }
        public decimal? HotTemperatureLimit { get; set; }
        public decimal HoursCount { get; set; }
        public decimal Percent { get; set; }
        public string Comment { get; set; }
        public string StsqpName { get; set; }
    }
}
