using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class CheckPayOrdersStatus
    {
        public int Id { get; set; }
        public long PayId { get; set; }
        public DateTime CheckDate { get; set; }

        public virtual Pay Pay { get; set; }
    }
}
