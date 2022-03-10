using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LsMpa110122HouseCounterDeltum
    {
        public long Id { get; set; }
        public long HouseCounterId { get; set; }
        public long? ServiceTypeId { get; set; }
        public DateTime Period { get; set; }
        public decimal? Delta { get; set; }
        public DateTime Created { get; set; }
        public long GroupOperId { get; set; }
        public bool IsNeedRecalc { get; set; }
    }
}
