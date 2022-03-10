using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentMoreFixedSum
    {
        public long Id { get; set; }
        public long? GroupOperationId { get; set; }
        public long? SpPaymentUno { get; set; }
        public long PersonId { get; set; }
        public long UserId { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }

        public virtual GroupOperation GroupOperation { get; set; }
        public virtual Person Person { get; set; }
        public virtual LocalTransaction SpPaymentUnoNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
