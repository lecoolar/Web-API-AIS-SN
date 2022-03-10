using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NormsForTko
    {
        public long Id { get; set; }
        public long? DistrictId { get; set; }
        public decimal AreaFrom { get; set; }
        public decimal AreaTo { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public decimal Value { get; set; }

        public virtual LocalDistrict District { get; set; }
    }
}
