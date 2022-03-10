using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentsView
    {
        public long Id { get; set; }
        public long Uno { get; set; }
        public DateTime Created { get; set; }
        public byte OpCodeId { get; set; }
        public decimal Summ { get; set; }
        public int Storno { get; set; }
        public long ServiceProviderId { get; set; }
        public long? AccountId { get; set; }
        public string AccountNumber { get; set; }
        public long AgentId { get; set; }
        public long UserId { get; set; }
        public string Terminal { get; set; }
        public string Fio { get; set; }
        public string Adr { get; set; }
        public long? ReversePaymentId { get; set; }
        public decimal Commission { get; set; }
        public string ServiceName { get; set; }
    }
}
