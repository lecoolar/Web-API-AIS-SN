using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SessionLockDatum
    {
        public long Id { get; set; }
        public long SessionId { get; set; }
        public DateTime LoginTime { get; set; }
        public long LockTableCode { get; set; }
        public long LockId { get; set; }
        public long LockSubId { get; set; }
        public string Message { get; set; }
    }
}
