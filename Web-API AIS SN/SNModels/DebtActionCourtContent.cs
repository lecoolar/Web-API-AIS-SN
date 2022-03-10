using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionCourtContent
    {
        public long Id { get; set; }
        public long DebtActionCourtStageId { get; set; }
        public int StatusId { get; set; }
        public DateTime? Created { get; set; }

        public virtual DebtActionCourtStage DebtActionCourtStage { get; set; }
        public virtual FasetItem Status { get; set; }
    }
}
