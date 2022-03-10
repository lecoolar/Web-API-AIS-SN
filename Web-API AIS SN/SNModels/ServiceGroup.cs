using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceGroup
    {
        public ServiceGroup()
        {
            ServiceGroupLinks = new HashSet<ServiceGroupLink>();
        }

        public long Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<ServiceGroupLink> ServiceGroupLinks { get; set; }
    }
}
