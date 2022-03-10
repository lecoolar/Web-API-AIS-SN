using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NodeServicesView
    {
        public long Id { get; set; }
        public long NodeId { get; set; }
        public int TypeId { get; set; }
        public string IpAddress { get; set; }
        public int? IpPort { get; set; }
        public string UrlAddress { get; set; }
        public bool? IsEnabled { get; set; }
        public string Name { get; set; }
    }
}
