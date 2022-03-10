using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PayBankComission
    {
        public long Id { get; set; }
        public long SmsrPayId { get; set; }
        public DateTime Created { get; set; }
        public decimal Summ { get; set; }
        public decimal Comm { get; set; }
        public string ResponseBank { get; set; }

        public virtual Pay SmsrPay { get; set; }
    }
}
