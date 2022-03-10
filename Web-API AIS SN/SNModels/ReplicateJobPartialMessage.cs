using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReplicateJobPartialMessage
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int Level { get; set; }
        public long JobPartialId { get; set; }
        public string ServerName { get; set; }
        public string MessageText { get; set; }
        public long TimeElapsed { get; set; }
    }
}
