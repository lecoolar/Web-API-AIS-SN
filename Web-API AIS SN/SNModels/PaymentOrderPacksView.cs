using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrderPacksView
    {
        public long Id { get; set; }
        public long PaymentOrderId { get; set; }
        public long PaymentAgentId { get; set; }
        public decimal Summ { get; set; }
        public string Number { get; set; }
        public decimal? PackSumm { get; set; }
        public int? PaymentCount { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
    }
}
