using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeXmlnotice
    {
        public NoticeXmlnotice()
        {
            NoticeXmlcounters = new HashSet<NoticeXmlcounter>();
            NoticeXmldata13s = new HashSet<NoticeXmldata13>();
            NoticeXmldata2s = new HashSet<NoticeXmldata2>();
            NoticeXmldata4s = new HashSet<NoticeXmldata4>();
            NoticeXmldata9s = new HashSet<NoticeXmldata9>();
            NoticeXmlpays = new HashSet<NoticeXmlpay>();
        }

        public long Id { get; set; }
        public long ActionId { get; set; }
        public long AccountId { get; set; }
        public string AllXml { get; set; }
        public string NoticeXml { get; set; }
        public int? IndexPart { get; set; }

        public virtual Action Action { get; set; }
        public virtual ICollection<NoticeXmlcounter> NoticeXmlcounters { get; set; }
        public virtual ICollection<NoticeXmldata13> NoticeXmldata13s { get; set; }
        public virtual ICollection<NoticeXmldata2> NoticeXmldata2s { get; set; }
        public virtual ICollection<NoticeXmldata4> NoticeXmldata4s { get; set; }
        public virtual ICollection<NoticeXmldata9> NoticeXmldata9s { get; set; }
        public virtual ICollection<NoticeXmlpay> NoticeXmlpays { get; set; }
    }
}
