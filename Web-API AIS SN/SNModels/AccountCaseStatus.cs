using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountCaseStatus
    {
        public long Id { get; set; }
        public long CaseId { get; set; }
        public int StatusFasetId { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Comment { get; set; }

        public virtual AccountCase Case { get; set; }
        public virtual FasetItem StatusFaset { get; set; }
        public virtual User User { get; set; }
    }
}
