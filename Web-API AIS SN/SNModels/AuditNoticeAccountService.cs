using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AuditNoticeAccountService
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public long AccountId { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Type { get; set; }
        public string HostName { get; set; }
        public string UserName { get; set; }
    }
}
