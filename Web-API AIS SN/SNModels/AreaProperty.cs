using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AreaProperty
    {
        public long Id { get; set; }
        public int PropertyId { get; set; }
        public string Value { get; set; }
        public long AreaId { get; set; }

        public virtual Area Area { get; set; }
        public virtual FasetItem Property { get; set; }
    }
}
