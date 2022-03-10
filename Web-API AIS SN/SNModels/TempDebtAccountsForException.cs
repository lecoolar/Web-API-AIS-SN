using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TempDebtAccountsForException
    {
        public long AccountId { get; set; }
        public DateTime? Period { get; set; }
        public DateTime? Created { get; set; }
    }
}
