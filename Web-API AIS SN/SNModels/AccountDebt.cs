using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountDebt
    {
        public long AccountId { get; set; }
        public decimal SumDebt { get; set; }
        public DateTime Created { get; set; }

        public virtual Account1 Account { get; set; }
    }
}
