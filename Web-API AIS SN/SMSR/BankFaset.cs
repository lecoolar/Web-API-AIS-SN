using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class BankFaset
    {
        public BankFaset()
        {
            PaymentAgents = new HashSet<PaymentAgent>();
        }

        public int BankCode { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PaymentAgent> PaymentAgents { get; set; }
    }
}
