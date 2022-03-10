using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSubstitution
    {
        public long Id { get; set; }
        public long? SourceServiceTypeId { get; set; }
        public long DestinationServiceTypeId { get; set; }
        public long? SourceServiceTypeIdByReport { get; set; }

        public virtual ServiceType DestinationServiceType { get; set; }
        public virtual ServiceType SourceServiceType { get; set; }
        public virtual ServiceType SourceServiceTypeIdByReportNavigation { get; set; }
    }
}
