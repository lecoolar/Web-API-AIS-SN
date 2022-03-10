using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceGroupLinksView
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public string ServiceGroupName { get; set; }
        public long ServiceId { get; set; }
        public int CodeService { get; set; }
        public string ServiceName { get; set; }
        public long ServiceProviderId { get; set; }
        public int ServiceProviderCode { get; set; }
        public string ServiceProviderName { get; set; }
        public DateTime Created { get; set; }
    }
}
