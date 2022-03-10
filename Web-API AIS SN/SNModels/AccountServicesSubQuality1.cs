using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicesSubQuality1
    {
        public long Id { get; set; }
        public long? AccountServiceId { get; set; }
        public DateTime? Period { get; set; }
        public DateTime? RangeStart { get; set; }
        public DateTime? RangeEnd { get; set; }
        public int? QualityTypeId { get; set; }
        public decimal? CalculatedPercent { get; set; }
        public decimal? CalculatedSumm { get; set; }
    }
}
