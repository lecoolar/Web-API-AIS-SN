using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrderPayLink
    {
        public long Id { get; set; }
        public long NoticePaymentOrderId { get; set; }
        public long JnId { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
    }
}
