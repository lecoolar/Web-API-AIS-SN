using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BarCode128
    {
        public int Code { get; set; }
        public int BarChar { get; set; }
        public string BinCode { get; set; }
    }
}
