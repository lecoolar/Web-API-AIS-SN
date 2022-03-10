using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UnloadData
    {
        public long Id { get; set; }
        public long UnloadId { get; set; }
        public int Number { get; set; }
        public string Data { get; set; }
    }
}
