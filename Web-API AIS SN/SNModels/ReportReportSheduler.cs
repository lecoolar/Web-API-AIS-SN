using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportReportSheduler
    {
        public long Id { get; set; }
        public long ReportId { get; set; }
        public long ReportShedulerId { get; set; }

        public virtual Report Report { get; set; }
        public virtual ReportSheduler ReportSheduler { get; set; }
    }
}
