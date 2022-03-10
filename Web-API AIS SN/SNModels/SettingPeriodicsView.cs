using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SettingPeriodicsView
    {
        public long Id { get; set; }
        public long SettingId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Value { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public string SettingGroupName { get; set; }
    }
}
