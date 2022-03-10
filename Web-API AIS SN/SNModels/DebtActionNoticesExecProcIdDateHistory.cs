using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionNoticesExecProcIdDateHistory
    {
        public long Id { get; set; }
        public long DebtActionNoticeId { get; set; }
        public DateTime ExecProcIdDateHistory { get; set; }
        public DateTime Created { get; set; }

        public virtual DebtActionNotice DebtActionNotice { get; set; }
    }
}
