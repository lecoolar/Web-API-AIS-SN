using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AddressObject
    {
        public string Code { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public long? AdrId { get; set; }
        public long? HouseCounterId { get; set; }
        public long? ApartmentCounterId { get; set; }
    }
}
