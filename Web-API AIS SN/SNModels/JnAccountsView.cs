using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnAccountsView
    {
        public DateTime Period { get; set; }
        public DateTime Created { get; set; }
        public long? ProviderId { get; set; }
        public long? ServiceTypeId { get; set; }
        public long AccountServiceId { get; set; }
        public long? AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountOwnerName { get; set; }
        public long? ApartmentId { get; set; }
        public long OperGroupId { get; set; }
        public decimal? OriginalSumm { get; set; }
        public long? GroupOperId { get; set; }
    }
}
