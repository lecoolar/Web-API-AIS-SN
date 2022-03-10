using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaymentService
    {
        public long Id { get; set; }
        public long WebServiceId { get; set; }
        public int ServiceCode { get; set; }
        public string TypeAction { get; set; }
        public long? PaymentCaseId { get; set; }
        public bool? PaymentPage { get; set; }
        public bool IsActive { get; set; }

        public virtual WebService WebService { get; set; }
    }
}
