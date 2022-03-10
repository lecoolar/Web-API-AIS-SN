using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestOrganizationCommissionsView
    {
        public long RequestId { get; set; }
        public long? ProviderId { get; set; }
        public decimal? Value { get; set; }
        public decimal? RequestProviderPaid { get; set; }
    }
}
