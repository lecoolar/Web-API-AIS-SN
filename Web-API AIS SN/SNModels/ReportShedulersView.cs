using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportShedulersView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long ReportTemplateId { get; set; }
        public string ReportTemplateName { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime NextTime { get; set; }
        public string Interval { get; set; }
        public int IntervalValue { get; set; }
        public int CompleateCount { get; set; }
        public bool Enable { get; set; }
        public bool DayBeginAllowShift { get; set; }
        public int ShiftDateBegin { get; set; }
        public int ShiftDateEnd { get; set; }
        public int? ShiftSecondDateBegin { get; set; }
        public int? ShiftSecondDateEnd { get; set; }
        public bool IsSimpleTable { get; set; }
        public bool IsTxt { get; set; }
        public bool? IsExcel { get; set; }
        public DateTime? LimitTimeBegin { get; set; }
        public DateTime? LimitTimeEnd { get; set; }
    }
}
