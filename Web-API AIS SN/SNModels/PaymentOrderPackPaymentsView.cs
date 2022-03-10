using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrderPackPaymentsView
    {
        public long? PaymentOrderPackId { get; set; }
        public string AccountNumber { get; set; }
        public decimal? Summ { get; set; }
        public string UserName { get; set; }
        public DateTime Created { get; set; }
    }
}
