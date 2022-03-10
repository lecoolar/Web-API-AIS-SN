using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DocumentServiceOrgsView
    {
        public long Id { get; set; }
        public long DocumentServiceId { get; set; }
        public string DocTypeName { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocFromDate { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string AgentName { get; set; }
        public long OrgId { get; set; }
        public string OrgName { get; set; }
    }
}
