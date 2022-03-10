using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TemperatureDesignLoadsView
    {
        public long Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal Temperature { get; set; }
        public long? AreaId { get; set; }
        public string Adrname { get; set; }
        public decimal? Alpha { get; set; }
    }
}
