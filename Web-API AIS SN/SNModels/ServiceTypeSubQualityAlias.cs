using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSubQualityAlias
    {
        public long Id { get; set; }
        public long ServiceTypeId { get; set; }
        public string Name { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
