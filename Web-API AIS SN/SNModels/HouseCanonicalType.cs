using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCanonicalType
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public int TypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual House House { get; set; }
        public virtual FasetItem Type { get; set; }
    }
}
