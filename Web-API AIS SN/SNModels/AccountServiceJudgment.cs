using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceJudgment
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual AccountService4 AccountService { get; set; }
    }
}
