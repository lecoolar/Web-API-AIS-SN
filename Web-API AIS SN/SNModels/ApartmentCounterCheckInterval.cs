using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterCheckInterval
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public DateTime FromDate { get; set; }
        public decimal? FromIndicationValue { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? ToIndicationValue { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public byte? Act { get; set; }

        public virtual ApartmentCounter Counter { get; set; }
        public virtual Session Session { get; set; }
        public virtual User User { get; set; }
    }
}
