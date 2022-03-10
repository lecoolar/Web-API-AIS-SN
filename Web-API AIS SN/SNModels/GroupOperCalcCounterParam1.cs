using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupOperCalcCounterParam1
    {
        public long Id { get; set; }
        public long GroupOperId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
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
        public long? CalcAlgsId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? CreatedPeriod { get; set; }
    }
}
