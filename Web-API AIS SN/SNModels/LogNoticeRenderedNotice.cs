using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LogNoticeRenderedNotice
    {
        public long AuditId { get; set; }
        public DateTime Period { get; set; }
        public long AccountId { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public DateTime? Created { get; set; }
        public long? ActionId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Type { get; set; }
        public string HostName { get; set; }
        public string UserName { get; set; }
    }
}
