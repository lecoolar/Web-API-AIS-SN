using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaymentBasis
    {
        public int PaymentAgentId { get; set; }
        public long WebServiceId { get; set; }
        public long Id { get; set; }
        public string TypePay { get; set; }
        public int? MinSummPaidForLk { get; set; }

        public virtual PaymentAgent PaymentAgent { get; set; }
        public virtual TypePay TypePayNavigation { get; set; }
        public virtual WebService WebService { get; set; }
    }
}
