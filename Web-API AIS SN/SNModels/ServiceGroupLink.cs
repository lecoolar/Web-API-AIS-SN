using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceGroupLink
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public long ServiceId { get; set; }
        public DateTime Created { get; set; }

        public virtual ServiceGroup Group { get; set; }
        public virtual Service1 Service { get; set; }
    }
}
