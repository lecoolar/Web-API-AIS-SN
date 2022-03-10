using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Payment
    {
        public Payment()
        {
            InverseReversePayment = new HashSet<Payment>();
        }

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

        public virtual Organization1 Agent { get; set; }
        public virtual OpCode OpCode { get; set; }
        public virtual Payment ReversePayment { get; set; }
        public virtual ServiceProvider ServiceProvider { get; set; }
        public virtual LocalTransaction UnoNavigation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Payment> InverseReversePayment { get; set; }
    }
}
