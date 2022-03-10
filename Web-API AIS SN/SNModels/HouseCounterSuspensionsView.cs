using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterSuspensionsView
    {
        public long Id { get; set; }
        public long HouseCounterId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public string TypeCounterName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public int? TypeSuspensionId { get; set; }
        public string TypeSuspensionName { get; set; }
        public bool IsCalculateAverage { get; set; }
        public decimal? AdditionalVolume { get; set; }
    }
}
