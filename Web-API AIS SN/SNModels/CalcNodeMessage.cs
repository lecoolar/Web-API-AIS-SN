using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcNodeMessage
    {
        public int Id { get; set; }
        public long? CalcNodeId { get; set; }
        public DateTime Created { get; set; }
        public string NodeMessage { get; set; }
        public int? ProcessType { get; set; }

        public virtual CalcNode CalcNode { get; set; }
    }
}
