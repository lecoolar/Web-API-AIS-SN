using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentRequestAccount
    {
        public long Id { get; set; }
        public long ApartmentRequestId { get; set; }
        public long AccountId { get; set; }
        public DateTime Created { get; set; }

        public virtual Account Account { get; set; }
        public virtual ApartmentRequest ApartmentRequest { get; set; }
    }
}
