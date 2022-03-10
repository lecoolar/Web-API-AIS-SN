using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSubQualityPercent
    {
        public ServiceTypeSubQualityPercent()
        {
            AccountServiceSubQualities = new HashSet<AccountServiceSubQuality>();
        }

        public long Id { get; set; }
        public long ServiceTypeSubQualityId { get; set; }
        public decimal? DeviationStart { get; set; }
        public decimal? DeviationEnd { get; set; }
        public decimal? TemperatureGradationStep { get; set; }
        public decimal? HotTemperatureLimit { get; set; }
        public decimal HoursCount { get; set; }
        public decimal Percent { get; set; }
        public string Comment { get; set; }

        public virtual ServiceTypeSubQuality ServiceTypeSubQuality { get; set; }
        public virtual ICollection<AccountServiceSubQuality> AccountServiceSubQualities { get; set; }
    }
}
