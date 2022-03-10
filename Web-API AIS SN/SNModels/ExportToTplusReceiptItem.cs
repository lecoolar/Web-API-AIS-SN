using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToTplusReceiptItem
    {
        public long ReceiptId { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Sum { get; set; }
        public string Unit { get; set; }
        public string PaymentMethod { get; set; }
        public decimal? VatSum { get; set; }
    }
}
