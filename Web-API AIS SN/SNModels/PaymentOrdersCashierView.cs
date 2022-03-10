using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrdersCashierView
    {
        public long Id { get; set; }
        public long PaymentAgentId { get; set; }
        public string PaymentAgentName { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Period { get; set; }
        public int? PackCount { get; set; }
        public decimal? PackSumm { get; set; }
    }
}
