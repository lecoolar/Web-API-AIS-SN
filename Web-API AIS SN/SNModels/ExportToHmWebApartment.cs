using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebApartment
    {
        public long ApartmentId { get; set; }
        public string ApartmentType { get; set; }
        public long HouseAddrId { get; set; }
        public string ApartmentName { get; set; }
        public decimal? TotalArea { get; set; }
        public decimal? LivingArea { get; set; }
        public decimal? HeatedArea { get; set; }
        public byte? RoomsCount { get; set; }
    }
}
