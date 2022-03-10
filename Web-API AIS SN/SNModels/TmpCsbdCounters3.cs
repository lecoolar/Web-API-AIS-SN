using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TmpCsbdCounters3
    {
        public long CounterId { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? LastIndicationValDate { get; set; }
        public decimal? PaymentInd { get; set; }
    }
}
