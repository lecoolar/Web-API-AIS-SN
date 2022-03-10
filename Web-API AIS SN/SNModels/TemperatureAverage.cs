using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TemperatureAverage
    {
        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public decimal Temperature { get; set; }
        public long? AreaId { get; set; }
        public DateTime Created { get; set; }

        public virtual Area Area { get; set; }
    }
}
