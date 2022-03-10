using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LogGroupNoticeRenderedNotice
    {
        public long AuditId { get; set; }
        public int Count { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Type { get; set; }
        public string HostName { get; set; }
        public string UserName { get; set; }
    }
}
