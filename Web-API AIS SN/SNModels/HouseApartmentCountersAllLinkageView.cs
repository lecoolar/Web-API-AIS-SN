using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseApartmentCountersAllLinkageView
    {
        public int Id { get; set; }
        public long HouseCounterId { get; set; }
        public long ApartmentCounterId { get; set; }
        public long ApartmentId { get; set; }
        public string AddressName { get; set; }
        public string ApartmentNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime? ApartmentFromDate { get; set; }
        public DateTime? ApartmentToDate { get; set; }
        public string Adr { get; set; }
        public string CounterName { get; set; }
        public DateTime ApartmentCounterFromDate { get; set; }
        public DateTime? ApartmentCounterToDate { get; set; }
        public string CounterTypeName { get; set; }
        public string MaddleTypeName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Created { get; set; }
        public string CounterNumber { get; set; }
    }
}
