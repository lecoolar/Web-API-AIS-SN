using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NormsForWaterView
    {
        public long Id { get; set; }
        public decimal Norma { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TypeWaterId { get; set; }
        public int? TypeHeatId { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceTypeId { get; set; }
        public string ServiceName { get; set; }
        public int? CodeService { get; set; }
        public string ServiceTypeName { get; set; }
        public int? CodeServiceType { get; set; }
        public string WaterName { get; set; }
        public string HeatName { get; set; }
    }
}
