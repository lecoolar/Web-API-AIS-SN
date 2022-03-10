using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestAccountServicesInfo
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public long AccountServiceId { get; set; }
        public string Comment { get; set; }
        public decimal? Paid { get; set; }
        public decimal? GroupPaid { get; set; }
    }
}
