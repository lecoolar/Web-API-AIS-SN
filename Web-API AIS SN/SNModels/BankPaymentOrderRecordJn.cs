using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BankPaymentOrderRecordJn
    {
        public long Id { get; set; }
        public long BankPaymentOrderRecordId { get; set; }
        public long JnId { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }

        public virtual BankPaymentOrdersRecord BankPaymentOrderRecord { get; set; }
        public virtual Jn1 Jn { get; set; }
    }
}
