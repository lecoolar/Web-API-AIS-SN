using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrder1
    {
        public PaymentOrder1()
        {
            PaymentOrderLinkPaymentOrderChildren = new HashSet<PaymentOrderLink>();
            PaymentOrderLinkPaymentOrderParents = new HashSet<PaymentOrderLink>();
            PaymentOrderPacks = new HashSet<PaymentOrderPack>();
            Reesters = new HashSet<Reester>();
        }

        public long Id { get; set; }
        public long PaymentAgentId { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Period { get; set; }
        public bool? IsCashier { get; set; }

        public virtual Organization1 PaymentAgent { get; set; }
        public virtual ICollection<PaymentOrderLink> PaymentOrderLinkPaymentOrderChildren { get; set; }
        public virtual ICollection<PaymentOrderLink> PaymentOrderLinkPaymentOrderParents { get; set; }
        public virtual ICollection<PaymentOrderPack> PaymentOrderPacks { get; set; }
        public virtual ICollection<Reester> Reesters { get; set; }
    }
}
