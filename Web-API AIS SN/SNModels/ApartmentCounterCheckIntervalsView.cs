using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterCheckIntervalsView
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public DateTime FromDate { get; set; }
        public decimal? FromIndicationValue { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? ToIndicationValue { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public byte? Act { get; set; }
        public string UserName { get; set; }
    }
}
