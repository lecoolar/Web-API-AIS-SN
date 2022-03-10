using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CounterIndicationsSidView
    {
        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public string AddressName { get; set; }
        public long? CounterId { get; set; }
        public string CounterName { get; set; }
        public decimal LastIndication { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? RequestId { get; set; }
        public long? CalcId { get; set; }
        public decimal? SummRecalc { get; set; }
        public long? SidId { get; set; }
        public int? Error { get; set; }
        public string ErrorMessage { get; set; }
        public int? IsPayment { get; set; }
        public long? GroupOperId { get; set; }
        public DateTime? DataIndications { get; set; }
        public DateTime? Created { get; set; }
        public decimal? CounterIndication { get; set; }
    }
}
