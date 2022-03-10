using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AddressesFromP
    {
        public string Adr { get; set; }
        public long? PsAddressId { get; set; }
        public long? SnAddressId { get; set; }
    }
}
