using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaymentCase
    {
        public long Id { get; set; }
        public int TypePaysId { get; set; }
        public int? MinSumPay { get; set; }
        public int? MaxSumPay { get; set; }
    }
}
