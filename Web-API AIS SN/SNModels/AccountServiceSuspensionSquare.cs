using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceSuspensionSquare
    {
        public long Id { get; set; }
        public long? SuspensionId { get; set; }
        public decimal RoomSquare { get; set; }
        public decimal RoomPercent { get; set; }

        public virtual AccountServiceSuspension Suspension { get; set; }
    }
}
