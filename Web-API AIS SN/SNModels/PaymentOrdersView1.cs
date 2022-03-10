using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrdersView1
    {
        public long Id { get; set; }
        public long PaymentAgentId { get; set; }
        public string PaymentAgentName { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Period { get; set; }
        public int? ReesterCount { get; set; }
        public decimal? ReesterSum { get; set; }
        public decimal? PaymentOrderLinkSumm { get; set; }
        public bool? IsParentPaymentOrder { get; set; }
        public bool? IsChildPaymentOrder { get; set; }
        public long? PaymentOrderMainId { get; set; }
        public string PaymentOrderMainName { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string AccountNumber { get; set; }
    }
}
