using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupOperationsViewNoOriginalSumm
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int? SubTypeId { get; set; }
        public long? PaymentAgentId { get; set; }
        public string PaymentAgentName { get; set; }
        public DateTime? TransactionDate { get; set; }
        public long? TransactionNumber { get; set; }
        public string Terminal { get; set; }
        public string ReesterNumber { get; set; }
        public DateTime? ReesterDate { get; set; }
        public string SubTypeName { get; set; }
        public long? DocId { get; set; }
        public string DocName { get; set; }
        public string DocNumber { get; set; }
        public DateTime? DocDate { get; set; }
        public string TypeDocName { get; set; }
        public string OrgName { get; set; }
        public int? OrgCode { get; set; }
        public string Comment { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public int? OldId { get; set; }
        public long? CalcId { get; set; }
        public long? AccountId { get; set; }
        public DateTime? IncomingTransferDate { get; set; }
        public string IncomingTransferNumber { get; set; }
        public string IncomingTransferPack { get; set; }
        public decimal? Summ { get; set; }
        public int? AccountsCount { get; set; }
        public string OperatorName { get; set; }
        public decimal? PaymentSumm { get; set; }
        public bool UsePaymentDate { get; set; }
        public bool? IsUseRecalc { get; set; }
        public string RequestServiceCode { get; set; }
        public bool IsProcessedByHand { get; set; }
        public string ArrivalBankAccount { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public DateTime? ReesterRecordDate { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public long? PaymentOrderId { get; set; }
        public long? BankPaymentOrderId { get; set; }
        public DateTime? BankPaymentOrderDate { get; set; }
        public bool? PayCurrentReceipt { get; set; }
        public string ReesterTypeName { get; set; }
        public string CourtProcessNumber { get; set; }
        public long? DebtActionId { get; set; }
        public int? SubService { get; set; }
        public string SubServiceName { get; set; }
        public long? PaymentSystemId { get; set; }
        public string PaymentSystemName { get; set; }
        public long? FiscalDoc { get; set; }
        public long? PayFiscalId { get; set; }
        public DateTime? PayFiscalDate { get; set; }
    }
}
