using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NonresidentialApartmentsView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long AddressId { get; set; }
        public string AddressName { get; set; }
        public long OwnerId { get; set; }
        public string OwnerName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
