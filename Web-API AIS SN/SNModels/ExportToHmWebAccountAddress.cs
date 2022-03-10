using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebAccountAddress
    {
        public long TransportAccountAddressId { get; set; }
        public long RemoteHouseAddrId { get; set; }
        public long RemoteLocalAddressId { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
        public string EntranceNumber { get; set; }
        public decimal? TotalArea { get; set; }
        public decimal? LivingArea { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }
        public int? LivingPerson { get; set; }
        public int? RoomsCount { get; set; }
    }
}
