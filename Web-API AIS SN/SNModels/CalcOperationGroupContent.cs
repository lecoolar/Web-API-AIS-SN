using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcOperationGroupContent
    {
        public long GroupId { get; set; }
        public byte OperId { get; set; }

        public virtual CalcOperationGroup Group { get; set; }
        public virtual CalcOperation Oper { get; set; }
    }
}
