using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Unload
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public int NumberRow { get; set; }
        public int Type { get; set; }
        public long IndexPart { get; set; }
        public int NumberInAction { get; set; }
        public long? AccountId { get; set; }
        public string FileName { get; set; }
        public DateTime Created { get; set; }
        public string DataPref { get; set; }
        public string DataPost { get; set; }
        public string DataUnion { get; set; }
    }
}
