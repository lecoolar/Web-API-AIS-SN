using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NonresidentialApartmentHouseCountersView
    {
        public long Id { get; set; }
        public long NonresidentialApartmentId { get; set; }
        public string AddressName { get; set; }
        public string OwnerName { get; set; }
        public long HouseCounterId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public string TypeCounterName { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string Coment { get; set; }
    }
}
