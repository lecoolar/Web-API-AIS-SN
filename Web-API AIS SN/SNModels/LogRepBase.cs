using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LogRepBase
    {
        public long AuditId { get; set; }
        public int TableId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Type { get; set; }
        public string HostName { get; set; }
        public string UserName { get; set; }
        public DateTime? Period { get; set; }
        public long? AreaId { get; set; }
        public long? AreaOrgId { get; set; }
        public string Comment { get; set; }
    }
}
