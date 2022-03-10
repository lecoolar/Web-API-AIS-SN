using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebClosedAccount
    {
        public long RemoteAccountId { get; set; }
        public long? RemoteHouseAddrId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string QueueType { get; set; }
    }
}
