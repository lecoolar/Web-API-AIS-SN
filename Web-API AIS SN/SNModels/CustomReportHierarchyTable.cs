using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CustomReportHierarchyTable
    {
        public long Id { get; set; }
        public string TableName { get; set; }
        public int? Level { get; set; }
        public long? ParentId { get; set; }
        public string Aliase { get; set; }
        public string AlterProcName { get; set; }
        public string FillProcName { get; set; }
        public string Comment { get; set; }
    }
}
