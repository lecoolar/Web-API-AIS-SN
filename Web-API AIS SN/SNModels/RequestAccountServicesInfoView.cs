using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestAccountServicesInfoView
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public long AccountServiceId { get; set; }
        public string Comment { get; set; }
        public decimal? Paid { get; set; }
        public decimal? GroupPaid { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceShortName { get; set; }
        public DateTime AccountServiceFromDate { get; set; }
        public DateTime? AccountServiceToDate { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderShortName { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderShortName { get; set; }
        public decimal? Debt { get; set; }
        public decimal? PositiveDebt { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? CurrentDebt { get; set; }
    }
}
