using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaymentBasesTemp
    {
        public int PaymentAgentId { get; set; }
        public long WebServiceId { get; set; }
        public string TypePay { get; set; }
        public int? MinSummPaidForLk { get; set; }
    }
}
