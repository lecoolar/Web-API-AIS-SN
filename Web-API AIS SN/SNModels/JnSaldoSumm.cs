using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnSaldoSumm
    {
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoPeny { get; set; }
        public decimal SaldoOutOfBalance { get; set; }

        public virtual AccountService4 AccountService { get; set; }
    }
}
