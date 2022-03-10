using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class OutMessage
    {
        public long Id { get; set; }
        public long LogId { get; set; }
        public string Value { get; set; }
        public string ReplyResult { get; set; }

        public virtual Log2 Log { get; set; }
    }
}
