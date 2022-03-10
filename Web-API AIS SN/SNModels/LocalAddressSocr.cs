using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalAddressSocr
    {
        public long Id { get; set; }
        public byte Level { get; set; }
        public string Socr { get; set; }
    }
}
