using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class MobilePay
    {
        public long Id { get; set; }
        public long? PaysId { get; set; }

        public virtual Pay Pays { get; set; }
    }
}
