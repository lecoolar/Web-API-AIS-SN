using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ProviderCode
    {
        public long OldCode { get; set; }
        public long NewCode { get; set; }
        public long ServiceId { get; set; }
    }
}
