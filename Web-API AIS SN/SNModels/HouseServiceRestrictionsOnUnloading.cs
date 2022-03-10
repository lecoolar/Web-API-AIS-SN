using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceRestrictionsOnUnloading
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceTypeId { get; set; }
        public long? ProviderId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? OrgDocumentId { get; set; }
        public DateTime? Created { get; set; }

        public virtual House House { get; set; }
        public virtual OrgDocument OrgDocument { get; set; }
        public virtual Organization1 Provider { get; set; }
        public virtual Service1 Service { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
