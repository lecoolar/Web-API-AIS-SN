using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountServicesView
    {
        public long Id { get; set; }
        public long DebtAccountId { get; set; }
        public long AccountServiceId { get; set; }
        public decimal? DebtSumm { get; set; }
        public short? MonthCount { get; set; }
        public long AccountId { get; set; }
        public string ServiceShortName { get; set; }
        public int ServiceCode { get; set; }
        public int? AccountServiceGroupCode { get; set; }
        public decimal? Peny { get; set; }
        public int? DebtRank { get; set; }
    }
}
