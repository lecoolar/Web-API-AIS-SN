using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountCasesService
    {
        public long Id { get; set; }
        public long AccountCasesId { get; set; }
        public long AccountId { get; set; }
        public decimal Debt { get; set; }
        public DateTime Period { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountCase AccountCases { get; set; }
    }
}
