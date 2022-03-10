using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentHouseHolder1
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long OrgId { get; set; }
        public DateTime FromDate { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual Organization1 Org { get; set; }
    }
}
