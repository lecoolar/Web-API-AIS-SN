using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountReportType
    {
        public AccountReportType()
        {
            AccountReports = new HashSet<AccountReport>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool? IsEnabled { get; set; }
        public bool IsStored { get; set; }
        public string ShortName { get; set; }
        public string Template { get; set; }
        public bool IsEnabledProvider { get; set; }

        public virtual ICollection<AccountReport> AccountReports { get; set; }
    }
}
