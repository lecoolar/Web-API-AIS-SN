using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Report
    {
        public Report()
        {
            ReportParameters = new HashSet<ReportParameter>();
            ReportReportShedulers = new HashSet<ReportReportSheduler>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long ReportTemplateId { get; set; }
        public long? UserId { get; set; }
        public int Status { get; set; }
        public string Result { get; set; }
        public DateTime? PlannedDate { get; set; }
        public int? CountFail { get; set; }
        public string Error { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string HostName { get; set; }
        public bool? IsVip { get; set; }
        public string FileName { get; set; }
        public int? SovaRequestId { get; set; }

        public virtual ReportPackedResult ReportPackedResult { get; set; }
        public virtual ICollection<ReportParameter> ReportParameters { get; set; }
        public virtual ICollection<ReportReportSheduler> ReportReportShedulers { get; set; }
    }
}
