using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReplicateJobPartialLocalTask
    {
        public long Id { get; set; }
        public long JobPartialId { get; set; }
        public DateTime? Started { get; set; }
        public bool? IsResult { get; set; }
        public bool? IsAccept { get; set; }
        public string ErrorProcess { get; set; }
        public string ErrorAccept { get; set; }
    }
}
