using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterApartmentsView
    {
        public long Id { get; set; }
        public long HouseCounterId { get; set; }
        public string CounterName { get; set; }
        public string TypeCounterName { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public string AddressName { get; set; }
        public string OwnerName { get; set; }
        public DateTime ApartmentFromDate { get; set; }
        public DateTime? ApartmentToDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
