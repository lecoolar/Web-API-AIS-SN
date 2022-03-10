using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceProvider
    {
        public long Id { get; set; }
        public long ServiceProviderId { get; set; }
        public long HouseId { get; set; }
        public long ServiceTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? ServiceHouseHolderId { get; set; }

        public virtual House House { get; set; }
        public virtual Organization1 ServiceHouseHolder { get; set; }
        public virtual Organization1 ServiceProvider { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
