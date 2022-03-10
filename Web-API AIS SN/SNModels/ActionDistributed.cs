using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionDistributed
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public long AreaId { get; set; }
        public int PartCount { get; set; }
        public int IndexPartPrimaryStation { get; set; }
        public int IsBreak { get; set; }
        public bool WorkModeBlocks { get; set; }

        public virtual Action Action { get; set; }
        public virtual Area Area { get; set; }
    }
}
