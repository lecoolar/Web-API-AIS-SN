using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LsMpa110122GroupOperation
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public int TypeId { get; set; }
        public int? SubTypeId { get; set; }
        public long? DocId { get; set; }
        public string Comment { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? CalcId { get; set; }
        public long? AccountId { get; set; }
        public long? PaymentAgentId { get; set; }
        public long? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ReesterNumber { get; set; }
        public DateTime? ReesterDate { get; set; }
        public string Terminal { get; set; }
        public DateTime? IncomingTransferDate { get; set; }
        public string IncomingTransferNumber { get; set; }
        public string IncomingTransferPack { get; set; }
        public string OperatorName { get; set; }
        public bool UsePaymentDate { get; set; }
        public bool? IsUseRecalc { get; set; }
        public long? PaymentOrderPackId { get; set; }
        public bool NoticeRecalcUseByPeriod { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public long? PaymentOrderId { get; set; }
        public long? BankPaymentOrderId { get; set; }
        public DateTime? BankPaymentOrderDate { get; set; }
        public DateTime? ReesterRecordPaymentDate { get; set; }
        public bool? PayCurrentReceipt { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public long? DebtActionId { get; set; }
        public int? SubService { get; set; }
        public long? PaymentSystemId { get; set; }
        public long? OldId { get; set; }
        public long? CreditOrgId { get; set; }
        public long? FiscalDoc { get; set; }
        public long? PayFiscalId { get; set; }
        public DateTime? PayFiscalDate { get; set; }
    }
}
