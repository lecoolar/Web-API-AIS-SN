using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class BaseSetting
    {
        public long Id { get; set; }
        public long BaseId { get; set; }
        public string SettingName { get; set; }
        public string Value { get; set; }
    }
}
