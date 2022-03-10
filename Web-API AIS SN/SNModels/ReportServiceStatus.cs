using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportServiceStatus
    {
        public long Id { get; set; }
        public string ServiceName { get; set; }
        public DateTime Created { get; set; }
        public DateTime CheckTime { get; set; }
        public string Mssg { get; set; }
        public int? IsLog { get; set; }
    }
}
