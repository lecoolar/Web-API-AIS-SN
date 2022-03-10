using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeAdditionalSettingsView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
        public bool IsEnable { get; set; }
        public int Priority { get; set; }
        public string Tag { get; set; }
        public string FixedPeriod { get; set; }
        public string AreaName { get; set; }
        public string HouseHolder { get; set; }
        public string AccountHouseHolder { get; set; }
        public string Subdivision { get; set; }
        public string ServiceProvider { get; set; }
        public DateTime? FixedPeriodFrom { get; set; }
        public DateTime? FixedPeriodTo { get; set; }
        public long? AccountHouseHolderId { get; set; }
    }
}
