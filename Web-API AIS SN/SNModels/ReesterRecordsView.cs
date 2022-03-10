using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReesterRecordsView
    {
        public long Id { get; set; }
        public long? ReesterId { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountNumberProvider { get; set; }
        public string AbonentName { get; set; }
        public string Address { get; set; }
        public decimal? PaymentSumm { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? Period { get; set; }
        public DateTime? ToPeriod { get; set; }
        public string Apx { get; set; }
        public string ExternalTransactionId { get; set; }
        public long? RequestId { get; set; }
        public string Error { get; set; }
        public int? SubService { get; set; }
        public string ProviderCode { get; set; }
        public long? PaymentSystemId { get; set; }
        public string PaymentSystemName { get; set; }
        public string ApxCounter { get; set; }
        public string CardType { get; set; }
        public decimal? Commission { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public DateTime? IndicationDate { get; set; }
        public string ReesterNumber { get; set; }
        public decimal? TransactionSumm { get; set; }
        public long? UserId { get; set; }
        public string Name { get; set; }
        public int CashPaymentOrderType { get; set; }
        public int? OtherPaymentAttributeId { get; set; }
        public string OtherPaymentAttributeName { get; set; }
        public long? GroupOperId { get; set; }
        public int? ReesterRecordTypeFasetId { get; set; }
        public string ReesterRecordTypeFasetName { get; set; }
        public bool? IsChargePenalty { get; set; }
    }
}
