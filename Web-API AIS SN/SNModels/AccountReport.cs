using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountReport
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long UserId { get; set; }
        public DateTime FromDate { get; set; }
        public long Number { get; set; }
        public long AccountReportTypeId { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountReportType AccountReportType { get; set; }
        public virtual User User { get; set; }
    }
}
