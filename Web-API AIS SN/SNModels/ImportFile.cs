using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ImportFile
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string ObjectTitle { get; set; }
        public byte[] ObjectData { get; set; }
        public string Comment { get; set; }
        public string ObjectName { get; set; }
        public string HashSumm { get; set; }
    }
}
