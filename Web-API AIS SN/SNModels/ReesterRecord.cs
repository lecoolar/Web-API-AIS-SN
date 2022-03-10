using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReesterRecord
    {
        public ReesterRecord()
        {
            PayJns = new HashSet<PayJn>();
            RequestGates = new HashSet<RequestGate>();
        }

        public long Id { get; set; }
        public long? ReesterId { get; set; }
        public int? StatusId { get; set; }
        public string AccountNumber { get; set; }
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
        public string ApxCounter { get; set; }
        public string CardType { get; set; }
        public decimal? Commission { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public string AccountNumberProvider { get; set; }
        public DateTime? IndicationDate { get; set; }
        public string ProviderCode { get; set; }
        public decimal? TransactionSumm { get; set; }
        public long? UserId { get; set; }
        public int? IsNewConsumption { get; set; }
        public decimal? PenaltySumm { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public bool? IsNewCounterConsumption { get; set; }
        public int CashPaymentOrderType { get; set; }
        public int? OtherPaymentAttributeId { get; set; }
        public long? GroupOperId { get; set; }
        public int? ReesterRecordTypeFasetId { get; set; }
        public bool? IsChargePenalty { get; set; }

        public virtual GroupOperation GroupOper { get; set; }
        public virtual FasetItem OtherPaymentAttribute { get; set; }
        public virtual Reester Reester { get; set; }
        public virtual FasetItem ReesterRecordTypeFaset { get; set; }
        public virtual FasetItem Status { get; set; }
        public virtual ICollection<PayJn> PayJns { get; set; }
        public virtual ICollection<RequestGate> RequestGates { get; set; }
    }
}
