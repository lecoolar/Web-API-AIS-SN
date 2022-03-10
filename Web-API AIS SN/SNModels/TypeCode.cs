using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TypeCode
    {
        public long OldTypeId { get; set; }
        public long NewTypeId { get; set; }
        public long OldCode { get; set; }
        public long NewCode { get; set; }
    }
}
