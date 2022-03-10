using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CanonicalServiceProperty
    {
        public long Id { get; set; }
        public long CanonicalServiceId { get; set; }
        public int? TypeId { get; set; }

        public virtual CanonicalService1 CanonicalService { get; set; }
        public virtual FasetItem Type { get; set; }
    }
}
