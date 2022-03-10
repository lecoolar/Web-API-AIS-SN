using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TypeChange
    {
        public long OldTypeId { get; set; }
        public long NewTypeId { get; set; }
        public long ServiceId { get; set; }
    }
}
