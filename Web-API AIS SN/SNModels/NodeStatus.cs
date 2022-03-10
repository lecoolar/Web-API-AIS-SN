using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NodeStatus
    {
        public NodeStatus()
        {
            Nodes = new HashSet<Node>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Node> Nodes { get; set; }
    }
}
