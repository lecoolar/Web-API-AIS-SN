using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseHouseHolder
    {
        public long Id { get; set; }
        public long HouseHolderId { get; set; }
        public long HouseId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public bool? IsNotViewPersonalDate { get; set; }

        public virtual House House { get; set; }
        public virtual Organization1 HouseHolder { get; set; }
    }
}
