using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionDistributedPartFile
    {
        public long ActionDistributedPartId { get; set; }
        public byte[] FileData { get; set; }
        public string FileName { get; set; }
    }
}
