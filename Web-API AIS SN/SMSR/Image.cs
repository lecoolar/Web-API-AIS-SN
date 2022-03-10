using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Image
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool? Show { get; set; }
    }
}
