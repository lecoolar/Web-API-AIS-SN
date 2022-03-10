using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrderPack
    {
        public long Id { get; set; }
        public long PaymentOrderId { get; set; }
        public string Number { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }

        public virtual PaymentOrder1 PaymentOrder { get; set; }
        public virtual User User { get; set; }
    }
}
