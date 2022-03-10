using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServiceBenefitNormsForGa2
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long CalcId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public DateTime RangeStart { get; set; }
        public long BenefitOwnerId { get; set; }
        public long ExploitingPersonId { get; set; }
        public int? TypeId { get; set; }
        public int? ExceptTypeId { get; set; }
        public decimal? Value { get; set; }
    }
}
