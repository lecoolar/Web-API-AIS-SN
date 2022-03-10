using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeInformationAddressesView
    {
        public long Id { get; set; }
        public long AddrId { get; set; }
        public string InformationText { get; set; }
        public string AddressName { get; set; }
        public byte AddressLevel { get; set; }
        public long? ParentAddrId { get; set; }
    }
}
