using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountProvidersView
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long ProviderId { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public string Number { get; set; }
        public DateTime Created { get; set; }
        public long? SubProviderId { get; set; }
        public int? SubProviderCode { get; set; }
        public string SubProviderName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
