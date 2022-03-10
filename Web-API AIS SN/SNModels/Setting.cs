using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Setting
    {
        public Setting()
        {
            ExchangeRequestGroups = new HashSet<ExchangeRequestGroup>();
            ExchangeRequests = new HashSet<ExchangeRequest>();
            SettingPeriodics = new HashSet<SettingPeriodic>();
        }

        public long Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }

        public virtual FasetItem Group { get; set; }
        public virtual ICollection<ExchangeRequestGroup> ExchangeRequestGroups { get; set; }
        public virtual ICollection<ExchangeRequest> ExchangeRequests { get; set; }
        public virtual ICollection<SettingPeriodic> SettingPeriodics { get; set; }
    }
}
