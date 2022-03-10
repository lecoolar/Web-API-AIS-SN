using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountServicesByPeriod
    {
        public long Id { get; set; }
        public long DebtAccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public decimal? Summ { get; set; }
        public DateTime? Created { get; set; }
        public int? DebtRank { get; set; }

        public virtual DebtAccountService DebtAccountService { get; set; }
    }
}
