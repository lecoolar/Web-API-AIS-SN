using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentOwnershipLegalization
    {
        public long Id { get; set; }
        public long? ApartmentOwnerId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual ApartmentOwner ApartmentOwner { get; set; }
    }
}
