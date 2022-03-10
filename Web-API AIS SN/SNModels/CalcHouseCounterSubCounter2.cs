using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounterSubCounter2
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long? CalcHouseCounterServiceId { get; set; }
        public long? HouseCounterId { get; set; }
        public decimal? Value { get; set; }
        public int? RelationTypeId { get; set; }
    }
}
