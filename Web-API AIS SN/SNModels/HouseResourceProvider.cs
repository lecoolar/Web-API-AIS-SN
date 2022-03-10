using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseResourceProvider
    {
        public long Id { get; set; }
        public long ResourceProviderId { get; set; }
        public long HouseId { get; set; }
        public long ServiceTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual House House { get; set; }
        public virtual Organization1 ResourceProvider { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
