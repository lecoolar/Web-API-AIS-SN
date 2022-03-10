using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountPeriodFkrV2
    {
        public long Id { get; set; }
        public long AbonentId { get; set; }
        public int? Number { get; set; }
        public DateTime Period { get; set; }
        public string AIndex { get; set; }
        public string Address { get; set; }
        public decimal? Tariff { get; set; }
        public decimal? Charge { get; set; }
        public decimal? Payment { get; set; }
        public int? NotLiving { get; set; }
        public decimal? Recalc { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? ToPay { get; set; }
        public DateTime? NormDatePay { get; set; }
        public DateTime? RecalcFrom { get; set; }
        public DateTime? RecalcTo { get; set; }
        public decimal? Square { get; set; }
        public decimal? SaldoBegin { get; set; }
        public decimal? SaldoPayment { get; set; }
        public decimal? SaldoEnd { get; set; }
        public decimal? SaldoPeny { get; set; }
        public string Info { get; set; }
        public DateTime? InfoDateDebt { get; set; }
        public DateTime? InfoDateToPay { get; set; }
        public long? HouseHolderCode { get; set; }
    }
}
