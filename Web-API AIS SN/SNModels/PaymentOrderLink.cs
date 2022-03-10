using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrderLink
    {
        public long Id { get; set; }
        public long PaymentOrderParentId { get; set; }
        public long PaymentOrderChildId { get; set; }

        public virtual PaymentOrder1 PaymentOrderChild { get; set; }
        public virtual PaymentOrder1 PaymentOrderParent { get; set; }
    }
}
