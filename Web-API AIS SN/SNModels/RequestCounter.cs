using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestCounter
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public long? CounterId { get; set; }
        public decimal? CounterIndication { get; set; }
        public decimal? NewCounterIndication { get; set; }
        public int? ServiceTypeCode { get; set; }
        public DateTime? ValDate { get; set; }
        public DateTime? NewValDate { get; set; }

        public virtual ApartmentCounter Counter { get; set; }
    }
}
