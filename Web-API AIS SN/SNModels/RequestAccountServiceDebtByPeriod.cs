using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestAccountServiceDebtByPeriod
    {
        public long RequestId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public decimal? Debt { get; set; }

        public virtual Request1 Request { get; set; }
    }
}
