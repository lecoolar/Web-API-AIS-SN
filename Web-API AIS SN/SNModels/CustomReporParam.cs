using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CustomReporParam
    {
        public long Id { get; set; }
        public string SelectedColumns { get; set; }
        public string GroupColumns { get; set; }
        public string SortedColumns { get; set; }
        public string SelectedTables { get; set; }
        public string SelectedColumnsXml { get; set; }
        public string GroupColumnsXml { get; set; }
        public string SortedColumnsXml { get; set; }
        public long? ReportTemplateId { get; set; }
        public string GroupTables { get; set; }
        public string InvisibleColsIds { get; set; }
        public string ColumnsConditions { get; set; }
        public string ColumnsConditionsXml { get; set; }
    }
}
