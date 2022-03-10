using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitPercentsView
    {
        public long Id { get; set; }
        public long ServiceSplitDocumentId { get; set; }
        public long OrgDocumentId { get; set; }
        public decimal Percent { get; set; }
        public bool ApplyPaymentPercentHere { get; set; }
        public long ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string OrgDocumentName { get; set; }
        public string DocNumber { get; set; }
    }
}
