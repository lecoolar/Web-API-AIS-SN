using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterLinkagesViewForLk
    {
        public long Id { get; set; }
        public long ApartmentCounterId { get; set; }
        public long ApartmentId { get; set; }
        public long AdrId { get; set; }
        public string AddressName { get; set; }
        public string ApartmentNumber { get; set; }
    }
}
