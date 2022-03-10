using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Log
    {
        public long? TemplateId { get; set; }
        public long? RecordId { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public long? AdrId { get; set; }
        public long? CityId { get; set; }
        public long? StreetId { get; set; }
        public long? HouseId { get; set; }
        public long? FlatId { get; set; }
        public long? HouseCounterId { get; set; }
        public long? ApartmentCounterId { get; set; }
        public string Error { get; set; }
        public long? OrgId { get; set; }
    }
}
