using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountAttachChargesView
    {
        public long Id { get; set; }
        public long DebtActionId { get; set; }
        public long JnId { get; set; }
        public DateTime? Created { get; set; }
        public decimal JnSumm { get; set; }
        public long? GroupOperationId { get; set; }
    }
}
