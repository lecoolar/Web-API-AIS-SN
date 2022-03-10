using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountAttachPaymentsView
    {
        public long Id { get; set; }
        public long DebtAccountId { get; set; }
        public long JnId { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public DateTime? AttachPeriod { get; set; }
        public decimal OriginalSumm { get; set; }
        public decimal? AttachSumm { get; set; }
        public long GroupOperId { get; set; }
        public DateTime? Created { get; set; }
        public long DebtActionId { get; set; }
        public long? DebtAffairOwnerId { get; set; }
    }
}
