using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SendQuery
    {
        public long Id { get; set; }
        public long? RequestId { get; set; }
        public string Phone { get; set; }
        public long? AccountId { get; set; }
        public string Respond { get; set; }
        public int? Result { get; set; }

        public virtual Account Account { get; set; }
        public virtual Request2 Request { get; set; }
    }
}
