using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CustomReportColumnsTable
    {
        public long Id { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public long? TableId { get; set; }
        public string NameParentColumn { get; set; }
        public string InterfaceName { get; set; }
        public string TableInterfaceName { get; set; }
        public string TableAliase { get; set; }
        public long? DataTypeId { get; set; }
        public string NameForDbf { get; set; }
    }
}
