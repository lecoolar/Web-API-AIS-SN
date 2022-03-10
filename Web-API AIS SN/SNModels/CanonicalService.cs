using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CanonicalService
    {
        public DateTime Period { get; set; }
        public long CanonicalId { get; set; }
        public string ShortName { get; set; }
    }
}
