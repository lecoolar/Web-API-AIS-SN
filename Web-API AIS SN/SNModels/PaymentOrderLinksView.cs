using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrderLinksView
    {
        public long Id { get; set; }
        public long PaymentOrderParentId { get; set; }
        public long PaymentOrderChildId { get; set; }
        public string PaymentOrderParentNumber { get; set; }
        public decimal PaymentOrderParentSumm { get; set; }
        public DateTime PaymentOrderParentDate { get; set; }
        public string PaymentOrderChildNumber { get; set; }
        public decimal PaymentOrderChildSumm { get; set; }
        public DateTime PaymentOrderChildDate { get; set; }
    }
}
