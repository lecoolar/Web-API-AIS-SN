using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnCalcCounterParam
    {
        public long Id { get; set; }
        public long JnId { get; set; }
        public long CounterId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? LastIndication { get; set; }
        public DateTime? LastIndicationDate { get; set; }
        public decimal? FirstIndication { get; set; }
        public DateTime? FirstIndicationDate { get; set; }
        public decimal? Consumption { get; set; }
        public decimal? ConsumptionDelta { get; set; }
        public long? UserId { get; set; }
        public DateTime RangeStart { get; set; }
        public decimal? ConsumptionFactor { get; set; }

        public virtual Jn1 Jn { get; set; }
    }
}
