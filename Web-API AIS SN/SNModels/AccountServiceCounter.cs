using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceCounter
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long CounterId { get; set; }
        public string CounterName { get; set; }
        public int? CounterSize { get; set; }
        public string CounterType { get; set; }
        public decimal? StartIndication { get; set; }
        public decimal? EndIndication { get; set; }
        public decimal? Consumption { get; set; }
        public decimal? Factor { get; set; }
        public decimal? PaymentShare { get; set; }
        public DateTime? CounterFromDate { get; set; }
        public decimal? ExternalFactor { get; set; }
        public DateTime? DateLastPay { get; set; }
        public DateTime? StartIndicationDate { get; set; }
        public DateTime? EndIndicationDate { get; set; }
        public DateTime Created { get; set; }
        public long? UserId { get; set; }
        public decimal? CounterSubTariffRate { get; set; }
    }
}
