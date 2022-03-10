using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class AccsOnPayView
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public string TypePay { get; set; }
        public string Phone { get; set; }
        public string TransactionNumber { get; set; }
        public decimal? Summa { get; set; }
        public string Comment { get; set; }
        public byte? Status { get; set; }
        public string Accpu { get; set; }
        public DateTime? DatePay { get; set; }
        public DateTime? Period { get; set; }
        public string StatusName { get; set; }
    }
}
