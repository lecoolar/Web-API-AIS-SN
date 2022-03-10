using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TemperatureInternalsView
    {
        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public decimal Temperature { get; set; }
        public int? HouseTypeId { get; set; }
        public DateTime Created { get; set; }
        public string HouseType { get; set; }
    }
}
