using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SettingsView
    {
        public long Id { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
        public int IsPeriodic { get; set; }
    }
}
