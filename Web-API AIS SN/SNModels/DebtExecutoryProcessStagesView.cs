using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtExecutoryProcessStagesView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long DebtActionNoticeId { get; set; }
        public long ApartmentOwnerId { get; set; }
        public string OwnerName { get; set; }
        public string ExecProcessNumber { get; set; }
        public DateTime? DateExecProcess { get; set; }
        public string PerformSheetNumber { get; set; }
        public DateTime? PerformSheetDate { get; set; }
    }
}
