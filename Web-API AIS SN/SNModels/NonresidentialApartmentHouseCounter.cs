using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NonresidentialApartmentHouseCounter
    {
        public long Id { get; set; }
        public long NonresidentialApartmentId { get; set; }
        public long HouseCounterId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? UserId { get; set; }
        public string Coment { get; set; }

        public virtual HouseCounter2 HouseCounter { get; set; }
        public virtual NonresidentialApartment NonresidentialApartment { get; set; }
    }
}
