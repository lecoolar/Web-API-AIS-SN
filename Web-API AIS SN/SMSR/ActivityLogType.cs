using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ActivityLogType
    {
        public ActivityLogType()
        {
            ActivityLogs = new HashSet<ActivityLog>();
        }

        public int Id { get; set; }
        public string SystemKeyword { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }
    }
}
