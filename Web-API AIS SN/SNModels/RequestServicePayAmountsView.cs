using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestServicePayAmountsView
    {
        public long Id { get; set; }
        public long? RequestId { get; set; }
        public long? Code { get; set; }
        public decimal? Paid { get; set; }
        public long? CounterId { get; set; }
        public decimal? CounterIndication { get; set; }
        public decimal? NoticeSumm { get; set; }
        public decimal? Penalty { get; set; }
        public long ServiceId { get; set; }
        public string ShortName { get; set; }
    }
}
