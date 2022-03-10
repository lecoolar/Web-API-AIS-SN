using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NormsForHeatingEnergy
    {
        public long Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Rate { get; set; }
        public long? AreaId { get; set; }
    }
}
