using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToTplusReceipt
    {
        public long Id { get; set; }
        public long GroupOperId { get; set; }
        public long AccountId { get; set; }
        public int Operation { get; set; }
        public DateTime? Timestamp { get; set; }
        public string LsNumber { get; set; }
        public decimal? PaymentSum { get; set; }
        public string PaymentType { get; set; }
        public decimal? VatSum { get; set; }
        public bool? Processed { get; set; }
    }
}
