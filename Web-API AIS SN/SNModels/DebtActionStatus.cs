using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionStatus
    {
        public DebtActionStatus()
        {
            DebtActionStatusCourtStages = new HashSet<DebtActionStatusCourtStage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public byte? GroupPage { get; set; }

        public virtual ICollection<DebtActionStatusCourtStage> DebtActionStatusCourtStages { get; set; }
    }
}
