using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Node
    {
        public int Id { get; set; }
        public string SrvName { get; set; }
        public string DbName { get; set; }
        public int? NodeStatusId { get; set; }
        public int CurrentRunCount { get; set; }
        public int MaxRunCount { get; set; }
        public int CurrentCounter { get; set; }
        public int? MaxCounter { get; set; }
        public int CurrentRecalc { get; set; }
        public int? MaxRecalc { get; set; }
        public int? CountCounter { get; set; }
        public int? CountRecalc { get; set; }

        public virtual NodeStatus NodeStatus { get; set; }
    }
}
