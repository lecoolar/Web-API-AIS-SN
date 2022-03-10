using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HeatPointsTplu
    {
        public long Id { get; set; }
        public string Fiascode { get; set; }
        public string BuildingGuid { get; set; }
        public string HeatpointGuid { get; set; }
    }
}
