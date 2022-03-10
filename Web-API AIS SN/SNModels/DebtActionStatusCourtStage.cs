using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionStatusCourtStage
    {
        public long Id { get; set; }
        public int? DebtActionStatusId { get; set; }
        public long? DebtActionCourtStageId { get; set; }

        public virtual DebtActionCourtStage DebtActionCourtStage { get; set; }
        public virtual DebtActionStatus DebtActionStatus { get; set; }
    }
}
