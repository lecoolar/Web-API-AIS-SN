using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Service
    {
        public DateTime Period { get; set; }
        public long ServiceId { get; set; }
        public string ShortName { get; set; }
        public long? AdrId { get; set; }
        public string AdrName { get; set; }
        public long? ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public long? ServiceApartmentTypeId { get; set; }
        public string ServiceApartmentTypeName { get; set; }
    }
}
