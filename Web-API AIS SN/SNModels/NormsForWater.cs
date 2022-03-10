using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NormsForWater
    {
        public long Id { get; set; }
        public decimal Norma { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TypeWaterId { get; set; }
        public int? TypeHeatId { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceTypeId { get; set; }
    }
}
