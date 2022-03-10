using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeNoticeAdditionalSetting
    {
        public long NoticeId { get; set; }
        public long NoticeAdditionalSettingId { get; set; }

        public virtual Notice Notice { get; set; }
        public virtual NoticeAdditionalSetting NoticeAdditionalSetting { get; set; }
    }
}
