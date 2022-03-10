using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionCourtStage
    {
        public DebtActionCourtStage()
        {
            DebtActionCourtContents = new HashSet<DebtActionCourtContent>();
            DebtActionStatusCourtStages = new HashSet<DebtActionStatusCourtStage>();
        }

        public string Name { get; set; }
        public DateTime? Created { get; set; }
        public long Id { get; set; }

        public virtual ICollection<DebtActionCourtContent> DebtActionCourtContents { get; set; }
        public virtual ICollection<DebtActionStatusCourtStage> DebtActionStatusCourtStages { get; set; }
    }
}
