using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeAccountInfoTax
    {
        public long? AccountId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? DateBalance { get; set; }
        public decimal? Indebted { get; set; }
        public string PaymentType { get; set; }
        public string TaxName { get; set; }
    }
}
