using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ModuleRight
    {
        public long Id { get; set; }
        public long ModuleId { get; set; }
        public int RightId { get; set; }

        public virtual Module Module { get; set; }
        public virtual Right Right { get; set; }
    }
}
