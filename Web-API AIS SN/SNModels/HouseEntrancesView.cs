using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseEntrancesView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long HouseAddrId { get; set; }
        public string HouseAddrName { get; set; }
        public int? HouseType { get; set; }
        public string Entrance { get; set; }
        public int? Floors { get; set; }
    }
}
