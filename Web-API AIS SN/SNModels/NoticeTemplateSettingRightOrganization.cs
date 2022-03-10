using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeTemplateSettingRightOrganization
    {
        public long Id { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public long OrganizationId { get; set; }

        public virtual NoticeTemplateSetting NoticeTemplateSetting { get; set; }
    }
}
