using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountService
    {
        public DebtAccountService()
        {
            DebtAccountServicesByPeriods = new HashSet<DebtAccountServicesByPeriod>();
        }

        public long Id { get; set; }
        public long DebtAccountId { get; set; }
        public long AccountServiceId { get; set; }
        public decimal? DebtSumm { get; set; }
        public short? MonthCount { get; set; }
        public string DebtAccountNumber { get; set; }
        public decimal? Peny { get; set; }
        public int? DebtRank { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual DebtAccount DebtAccount { get; set; }
        public virtual ICollection<DebtAccountServicesByPeriod> DebtAccountServicesByPeriods { get; set; }
    }
}
