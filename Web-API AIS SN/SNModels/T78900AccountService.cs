using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T78900AccountService
    {
        public string Address { get; set; }
        public double? PercentAffected { get; set; }
        public double? PercentAffected2 { get; set; }
        public double? ItogPercentAffected { get; set; }
        public long StreetId { get; set; }
        public long HouseId { get; set; }
        public long FlatId { get; set; }
        public long ApartmentId { get; set; }
        public long Accid { get; set; }
        public long AccountServiceId { get; set; }
    }
}
