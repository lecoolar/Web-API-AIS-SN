using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Setting
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string UserName { get; set; }
    }
}
