using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NodeServiceType
    {
        public NodeServiceType()
        {
            NodeServices = new HashSet<NodeService>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<NodeService> NodeServices { get; set; }
    }
}
