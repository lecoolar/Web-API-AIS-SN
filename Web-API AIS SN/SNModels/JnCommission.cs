using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnCommission
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long PaymentAgentId { get; set; }
        public DateTime Created { get; set; }
        public decimal Summ { get; set; }
        public int CalcOperId { get; set; }
        public long? GroupOperId { get; set; }

        public virtual Account Account { get; set; }
        public virtual FasetItem CalcOper { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual Organization1 PaymentAgent { get; set; }
    }
}
