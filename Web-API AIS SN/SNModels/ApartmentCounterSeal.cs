using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterSeal
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string Comment { get; set; }
        public long? UserId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public long? SessionId { get; set; }
        public byte? Act { get; set; }
        public int? SealType { get; set; }

        public virtual ApartmentCounter Counter { get; set; }
        public virtual FasetItem SealTypeNavigation { get; set; }
        public virtual Session Session { get; set; }
        public virtual User User { get; set; }
    }
}
