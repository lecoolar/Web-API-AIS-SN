using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrderAccountsView
    {
        public long Id { get; set; }
        public long NoticePaymentOrderId { get; set; }
        public long? AccountId { get; set; }
        public string AccountNumber { get; set; }
        public long? AccountServiceId { get; set; }
        public long? ServiceTypeId { get; set; }
        public string ServiceType { get; set; }
        public decimal? Summ { get; set; }
        public DateTime? Created { get; set; }
        public string Address { get; set; }
        public decimal? TotalArea { get; set; }
        public decimal? ServiceTariff { get; set; }
        public int? CountDay { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
    }
}
