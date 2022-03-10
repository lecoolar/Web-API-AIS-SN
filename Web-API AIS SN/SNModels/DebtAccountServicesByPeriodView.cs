using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountServicesByPeriodView
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public long DebtAccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public decimal? Summ { get; set; }
        public long DebtAccountId { get; set; }
        public short? MonthCount { get; set; }
        public DateTime AccountServiceFromDate { get; set; }
        public DateTime? AccountServiceToDate { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public int? AccountServiceHolderCode { get; set; }
        public string AccountServiceHolderName { get; set; }
        public int? DebtRank { get; set; }
    }
}
