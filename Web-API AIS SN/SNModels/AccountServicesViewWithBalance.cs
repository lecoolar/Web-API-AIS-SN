using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicesViewWithBalance
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Balance { get; set; }
        public decimal? BalancePeni { get; set; }
        public string ServiceShortName { get; set; }
        public int ServiceCode { get; set; }
        public long ProviderId { get; set; }
    }
}
