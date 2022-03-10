using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReplicateJobPartial
    {
        public long Id { get; set; }
        public long JobId { get; set; }
        public long Num { get; set; }
        public long? ServerId { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Finished { get; set; }
        public bool? IsResult { get; set; }
        public string ErrorProcess { get; set; }
        public string ErrorAccept { get; set; }
    }
}
