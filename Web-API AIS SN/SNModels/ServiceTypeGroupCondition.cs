using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeGroupCondition
    {
        public long Id { get; set; }
        public long GroupId { get; set; }
        public int? RuleRateId { get; set; }
        public int? RuleNormRateId { get; set; }
        public int? RuleResurceId { get; set; }
        public bool SplitByPeriod { get; set; }
        public int? RateDecimalPlace { get; set; }
        public int? NormRateDecimalPlace { get; set; }
        public int? ResourceDecimalPlace { get; set; }

        public virtual ServiceTypeGroup Group { get; set; }
        public virtual FasetItem RuleNormRate { get; set; }
        public virtual FasetItem RuleRate { get; set; }
        public virtual FasetItem RuleResurce { get; set; }
    }
}
