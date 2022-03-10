using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RefinancingRatesByPeriod
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public decimal RefinancingRate { get; set; }
        public string Comment { get; set; }
    }
}
