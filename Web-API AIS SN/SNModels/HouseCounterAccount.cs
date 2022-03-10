using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterAccount
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public long HouseCounterId { get; set; }
        public long AccountId { get; set; }
        public decimal NormativVolume { get; set; }
    }
}
