using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceSeasonsView
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public long HouseId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
    }
}
