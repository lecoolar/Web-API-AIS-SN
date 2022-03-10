using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Action
    {
        public Action()
        {
            ActionDistributedParts = new HashSet<ActionDistributedPart>();
            ActionParameters = new HashSet<ActionParameter>();
            ActionTemplates = new HashSet<ActionTemplate>();
            NoticeXmlnotices = new HashSet<NoticeXmlnotice>();
            Notices = new HashSet<Notice>();
            RenderedNotices = new HashSet<RenderedNotice>();
            ResultAccountNotices = new HashSet<ResultAccountNotice>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Comment { get; set; }
        public bool StartFromArmpaymentNotices { get; set; }
        public long? UserId { get; set; }
        public DateTime Period { get; set; }
        public int? CountAccounts { get; set; }
        public long? NoticeTemplateSettingIdIfOne { get; set; }

        public virtual NoticeTemplateSetting NoticeTemplateSettingIdIfOneNavigation { get; set; }
        public virtual ActionDistributed ActionDistributed { get; set; }
        public virtual ICollection<ActionDistributedPart> ActionDistributedParts { get; set; }
        public virtual ICollection<ActionParameter> ActionParameters { get; set; }
        public virtual ICollection<ActionTemplate> ActionTemplates { get; set; }
        public virtual ICollection<NoticeXmlnotice> NoticeXmlnotices { get; set; }
        public virtual ICollection<Notice> Notices { get; set; }
        public virtual ICollection<RenderedNotice> RenderedNotices { get; set; }
        public virtual ICollection<ResultAccountNotice> ResultAccountNotices { get; set; }
    }
}
