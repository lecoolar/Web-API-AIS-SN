using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicePaymentInstallmentsView
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long? DocId { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
        public decimal? Percent { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ServiceCode { get; set; }
        public string DocNumber { get; set; }
        public DateTime? StartPeriod { get; set; }
        public int? PeriodCount { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? DatePayment { get; set; }
        public DateTime? LastDayOfMonthCorrect { get; set; }
        public string Comment { get; set; }
        public decimal PartSumm { get; set; }
        public DateTime? DateOfInstallmentAgreement { get; set; }
    }
}
