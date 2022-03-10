using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeGroup
    {
        public ServiceTypeGroup()
        {
            ServiceTypeGroupConditions = new HashSet<ServiceTypeGroupCondition>();
        }

        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long ChildId { get; set; }
        public int GroupTypeId { get; set; }
        public string Name { get; set; }
        public int? Code { get; set; }
        public int? IsTariffZero { get; set; }

        public virtual ServiceType Child { get; set; }
        public virtual FasetItem GroupType { get; set; }
        public virtual ServiceType Parent { get; set; }
        public virtual ICollection<ServiceTypeGroupCondition> ServiceTypeGroupConditions { get; set; }
    }
}
