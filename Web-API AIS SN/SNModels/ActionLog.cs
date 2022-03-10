using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionLog
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public string ProcName { get; set; }
        public string Message { get; set; }
        public DateTime? TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }
        public int? TimeElapsed { get; set; }

        public virtual Action1 Action { get; set; }
    }
}
