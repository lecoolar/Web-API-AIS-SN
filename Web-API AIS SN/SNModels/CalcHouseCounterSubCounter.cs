using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounterSubCounter
    {
        public long Id { get; set; }
        public long? CalcHouseCounterServiceId { get; set; }
        public long? HouseCounterId { get; set; }
        public decimal? Value { get; set; }
        public int? RelationTypeId { get; set; }
    }
}
