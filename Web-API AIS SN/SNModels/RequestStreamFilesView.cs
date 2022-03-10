using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestStreamFilesView
    {
        public long Id { get; set; }
        public long MpaRequestId { get; set; }
        public long StreamFilesId { get; set; }
        public long? AccountId { get; set; }
        public string RequestComment { get; set; }
        public DateTime? RequestCreated { get; set; }
        public long? GroupOperId { get; set; }
        public long? MapId { get; set; }
        public byte? RequestTypeId { get; set; }
        public byte Status { get; set; }
        public long? StepId { get; set; }
        public string XmlIn { get; set; }
        public long? AddrId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ReplyDate { get; set; }
        public string CompletedWork { get; set; }
        public long? UserId { get; set; }
        public byte[] FileByte { get; set; }
        public DateTime? FileCreated { get; set; }
        public string ObjectTitle { get; set; }
        public string Comment { get; set; }
        public string HashSumm { get; set; }
        public long OrgDocId { get; set; }
    }
}
