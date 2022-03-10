using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcOperationGroupContentsView
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsInverted { get; set; }
        public byte OperId { get; set; }
        public string OperName { get; set; }
        public short? OpSign { get; set; }
        public int? OffBalanceBenefit { get; set; }
    }
}
