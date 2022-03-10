using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeTemplateProvider
    {
        public long Id { get; set; }
        public long NoticeTemplateId { get; set; }
        public long ProviderId { get; set; }

        public virtual NoticeTemplate NoticeTemplate { get; set; }
    }
}
