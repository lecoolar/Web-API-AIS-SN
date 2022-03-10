using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnSaldo
    {
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public decimal Saldo { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Charge { get; set; }
        public decimal Recalc { get; set; }
        public decimal Payment { get; set; }
        public long? GroupOperId { get; set; }

        public virtual AccountService4 AccountService { get; set; }
    }
}
