using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceChange
    {
        public long ServiceId { get; set; }
        public int? OldCode { get; set; }
        public int? NewCode { get; set; }
    }
}
