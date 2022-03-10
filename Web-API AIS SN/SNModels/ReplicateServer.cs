using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReplicateServer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string MainLinkedName { get; set; }
        public int? StatusId { get; set; }
    }
}
