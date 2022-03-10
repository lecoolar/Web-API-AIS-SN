using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeTemplateSettingParameter
    {
        public long Id { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public string Value { get; set; }
        public string PrintValue { get; set; }
        public string SubType { get; set; }

        public virtual NoticeTemplateSetting NoticeTemplateSetting { get; set; }
    }
}
