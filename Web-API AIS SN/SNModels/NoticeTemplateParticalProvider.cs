using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeTemplateParticalProvider
    {
        public long Id { get; set; }
        public long NoticeTemplateId { get; set; }
        public int PartCode { get; set; }
        public long ProviderId { get; set; }
        public bool? IsPrint { get; set; }
        public long? ForceHouseHolderId { get; set; }
    }
}
