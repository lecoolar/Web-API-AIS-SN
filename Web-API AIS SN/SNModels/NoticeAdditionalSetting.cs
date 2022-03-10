using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeAdditionalSetting
    {
        public NoticeAdditionalSetting()
        {
            NoticeAdditionalSettingsParams = new HashSet<NoticeAdditionalSettingsParam>();
            NoticeNoticeAdditionalSettings = new HashSet<NoticeNoticeAdditionalSetting>();
        }

        public long Id { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
        public bool? IsEnable { get; set; }
        public int Priority { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<NoticeAdditionalSettingsParam> NoticeAdditionalSettingsParams { get; set; }
        public virtual ICollection<NoticeNoticeAdditionalSetting> NoticeNoticeAdditionalSettings { get; set; }
    }
}
