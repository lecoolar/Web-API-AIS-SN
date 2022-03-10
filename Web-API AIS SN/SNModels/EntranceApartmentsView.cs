using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EntranceApartmentsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long AdrId { get; set; }
        public string ApartmentNumber { get; set; }
        public string ApartmentAddrName { get; set; }
        public long HouseEntranceId { get; set; }
        public long HouseId { get; set; }
        public long HouseAddrId { get; set; }
        public string HouseAddrName { get; set; }
        public string HouseEntrance { get; set; }
        public int? EntranceFloors { get; set; }
    }
}
