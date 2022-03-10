using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class MrtTemplate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public bool IsActiv { get; set; }
    }
}
