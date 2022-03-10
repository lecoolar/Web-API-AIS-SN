using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterVolume
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public decimal Volum { get; set; }
        public int ValType { get; set; }
        public DateTime ValDate { get; set; }
        public DateTime Created { get; set; }
        public long? GroupOperId { get; set; }
        public string Comment { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public byte? Act { get; set; }
        public long? InvoiceNumber { get; set; }

        public virtual ApartmentCounter Counter { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual Session Session { get; set; }
        public virtual User User { get; set; }
        public virtual FasetItem ValTypeNavigation { get; set; }
    }
}
