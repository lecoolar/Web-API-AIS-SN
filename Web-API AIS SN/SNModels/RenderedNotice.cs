using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RenderedNotice
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long AccountId { get; set; }
        public string Barcode { get; set; }
        public long? HouseHolderId { get; set; }
        public byte[] PacketReport { get; set; }
        public int? PageCount { get; set; }
        public bool HasResult { get; set; }
        public int? PrintTypeId { get; set; }
        public long? ParentId { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public long? ActionId { get; set; }
        public long? NoticeTemplateId { get; set; }
        public string AccountCsv { get; set; }
        public string GeneralParams { get; set; }

        public virtual Action Action { get; set; }
    }
}
