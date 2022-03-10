using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Log1
    {
        public long AuditId { get; set; }
        public string Type { get; set; }
        public string PrimaryKeyValue { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string HostName { get; set; }
        public string UserName { get; set; }
        public int? TableId { get; set; }
        public long? ActionId { get; set; }
    }
}
