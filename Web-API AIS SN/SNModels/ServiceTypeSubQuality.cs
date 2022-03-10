using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSubQuality
    {
        public ServiceTypeSubQuality()
        {
            ServiceTypeSubQualityAcceptableDurations = new HashSet<ServiceTypeSubQualityAcceptableDuration>();
            ServiceTypeSubQualityPercents = new HashSet<ServiceTypeSubQualityPercent>();
        }

        public long Id { get; set; }
        public long ServiceTypeId { get; set; }
        public int? QualityTypeId { get; set; }
        public string QualityName { get; set; }
        public string Normativ { get; set; }
        public string SuspensionRule { get; set; }
        public long OrgDocId { get; set; }
        public bool IsArchive { get; set; }

        public virtual OrgDocument OrgDoc { get; set; }
        public virtual FasetItem QualityType { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<ServiceTypeSubQualityAcceptableDuration> ServiceTypeSubQualityAcceptableDurations { get; set; }
        public virtual ICollection<ServiceTypeSubQualityPercent> ServiceTypeSubQualityPercents { get; set; }
    }
}
