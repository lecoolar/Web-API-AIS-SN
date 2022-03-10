using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeInformationAddress1
    {
        public long Id { get; set; }
        public long AddrId { get; set; }
        public string InformationText { get; set; }

        public virtual LocalAddress Addr { get; set; }
    }
}
