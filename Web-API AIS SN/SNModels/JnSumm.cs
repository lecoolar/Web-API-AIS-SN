using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnSumm
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public DateTime Created { get; set; }
        public long? HashPeriod { get; set; }
        public long? HashSaldoBegin { get; set; }
        public decimal? SaldoBegin { get; set; }
        public decimal? SaldoEnd { get; set; }
        public decimal? Charge { get; set; }
        public decimal? Recalc { get; set; }
        public decimal? Payment { get; set; }
    }
}
