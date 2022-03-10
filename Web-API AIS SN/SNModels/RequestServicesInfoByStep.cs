using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestServicesInfoByStep
    {
        public long Id { get; set; }
        public int Step { get; set; }
        public long RequestId { get; set; }
        public long Code { get; set; }
        public decimal? Paid { get; set; }
        public decimal? PaidPenalty { get; set; }

        public virtual Request1 Request { get; set; }
    }
}
