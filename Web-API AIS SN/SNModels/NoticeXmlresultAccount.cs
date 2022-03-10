using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeXmlresultAccount
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long AccountId { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public bool HasResult { get; set; }
        public string DataXml { get; set; }
    }
}
