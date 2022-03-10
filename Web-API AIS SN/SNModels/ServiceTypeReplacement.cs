using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeReplacement
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public long ChildId { get; set; }

        public virtual ServiceType Child { get; set; }
        public virtual ServiceType Parent { get; set; }
    }
}
