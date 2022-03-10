using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestItem
    {
        public RequestItem()
        {
            RequestItemParams = new HashSet<RequestItemParam>();
        }

        public long Id { get; set; }
        public long RequestId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public long? GroupOperId { get; set; }
        public string Error { get; set; }
        public string Comment { get; set; }

        public virtual Request Request { get; set; }
        public virtual ICollection<RequestItemParam> RequestItemParams { get; set; }
    }
}
