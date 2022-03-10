using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnBankPaymentOrderOutput
    {
        public long Id { get; set; }
        public long JnId { get; set; }
        public long OrgId { get; set; }
        public long BankPaymentOrderId { get; set; }

        public virtual BankPaymentOrder BankPaymentOrder { get; set; }
        public virtual Jn1 Jn { get; set; }
        public virtual Organization1 Org { get; set; }
    }
}
