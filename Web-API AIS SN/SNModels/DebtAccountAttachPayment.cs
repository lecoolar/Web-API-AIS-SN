using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountAttachPayment
    {
        public long Id { get; set; }
        public long DebtAccountId { get; set; }
        public long JnId { get; set; }
        public DateTime? AttachPeriod { get; set; }
        public decimal? AttachSumm { get; set; }
        public long GroupOperId { get; set; }
        public DateTime? Created { get; set; }
        public long DebtActionId { get; set; }
        public bool IsGosposhlina { get; set; }
        public long? DebtAffairOwnerId { get; set; }

        public virtual DebtAccount DebtAccount { get; set; }
        public virtual DebtAction DebtAction { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual Jn1 Jn { get; set; }
    }
}
