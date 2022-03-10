using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtRecoveredAmount
    {
        public long Id { get; set; }
        public long DebtAccountId { get; set; }
        public long? DebtActionNoticeId { get; set; }
        public decimal Summ { get; set; }
        public decimal Gosposhlina { get; set; }
        public decimal Penalty { get; set; }

        public virtual DebtAccount DebtAccount { get; set; }
        public virtual DebtActionNotice DebtActionNotice { get; set; }
    }
}
