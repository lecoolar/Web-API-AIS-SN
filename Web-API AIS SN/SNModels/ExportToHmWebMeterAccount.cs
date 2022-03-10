using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebMeterAccount
    {
        public long RemoteMeterId { get; set; }
        public int IsCollectiveCounter { get; set; }
        public string AccountNumber { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }
        public long? TransportMeterId { get; set; }
        public long? TransportAccountProviderId { get; set; }
    }
}
