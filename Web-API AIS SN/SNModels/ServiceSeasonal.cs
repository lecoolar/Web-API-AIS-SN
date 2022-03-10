using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSeasonal
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual Service1 Service { get; set; }
    }
}
