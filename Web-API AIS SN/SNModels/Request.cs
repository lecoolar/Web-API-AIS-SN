using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Request
    {
        public Request()
        {
            RequestApps = new HashSet<RequestApp>();
            RequestItems = new HashSet<RequestItem>();
        }

        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public long? MapId { get; set; }
        public long? StepId { get; set; }
        public long? AccountId { get; set; }
        public byte? Status { get; set; }
        public string XmlIn { get; set; }
        public string Comment { get; set; }
        public long? GroupOperId { get; set; }
        public byte? RequestTypeId { get; set; }
        public long? AddrId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ReplyDate { get; set; }
        public string CompletedWork { get; set; }
        public byte[] Attachments { get; set; }
        public long? UserId { get; set; }
        public DateTime Processed { get; set; }
        public long? RequestFrom { get; set; }

        public virtual Account Account { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<RequestApp> RequestApps { get; set; }
        public virtual ICollection<RequestItem> RequestItems { get; set; }
    }
}
