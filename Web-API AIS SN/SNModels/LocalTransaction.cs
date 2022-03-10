using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalTransaction
    {
        public LocalTransaction()
        {
            PaymentMoreFixedSums = new HashSet<PaymentMoreFixedSum>();
            Payments = new HashSet<Payment>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? RequestId { get; set; }

        public virtual ICollection<PaymentMoreFixedSum> PaymentMoreFixedSums { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
