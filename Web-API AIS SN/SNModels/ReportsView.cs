using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportsView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long ReportTemplateId { get; set; }
        public string ReportTemplateName { get; set; }
        public string Sql { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public int Status { get; set; }
        public string Result { get; set; }
        public byte[] PackedResult { get; set; }
        public DateTime? PlannedDate { get; set; }
        public bool IsSimpleTable { get; set; }
        public bool IsTxt { get; set; }
        public bool? IsExcel { get; set; }
        public int? CountFail { get; set; }
        public string Error { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public bool? IsVip { get; set; }
        public string FileName { get; set; }
        public int? SovaRequestId { get; set; }
        public string StatusName { get; set; }
    }
}
