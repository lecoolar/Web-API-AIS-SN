using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceProvidersView
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string OrgName { get; set; }
    }
}
