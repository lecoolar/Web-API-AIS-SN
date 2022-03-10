using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCountersMop
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public long AccountServiceId { get; set; }
        public long HouseCounterId { get; set; }
        public decimal Delta { get; set; }
        public decimal? Charge { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Coefficient { get; set; }
    }
}
