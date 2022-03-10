using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CompareCalc
    {
        public int CompareNum { get; set; }
        public DateTime Created { get; set; }
        public string HostName { get; set; }
        public long? UserId { get; set; }
        public long? ReportId { get; set; }
    }
}
