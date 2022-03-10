using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Log2
    {
        public Log2()
        {
            OutMessages = new HashSet<OutMessage>();
        }

        public long Id { get; set; }
        public long? AccountId { get; set; }
        public long? QueryTypeId { get; set; }
        public string InMessage { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? OutDate { get; set; }
        public bool IsProcessStarted { get; set; }
        public bool IsProcessFinished { get; set; }
        public bool IsReplied { get; set; }
        public long? PhoneId { get; set; }
        public string Error { get; set; }
        public string Gate { get; set; }
        public DateTime Created { get; set; }

        public virtual QueryType QueryType { get; set; }
        public virtual ICollection<OutMessage> OutMessages { get; set; }
    }
}
