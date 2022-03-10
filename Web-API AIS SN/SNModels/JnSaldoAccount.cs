using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnSaldoAccount
    {
        public long AccountId { get; set; }
        public DateTime Period { get; set; }
        public decimal Saldo { get; set; }
        public decimal Payment { get; set; }
        public long? GroupOperId { get; set; }

        public virtual Account Account { get; set; }
    }
}
