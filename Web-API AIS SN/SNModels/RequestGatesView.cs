using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestGatesView
    {
        public long Id { get; set; }
        public long? RequestId { get; set; }
        public int? RequestTypeFasetId { get; set; }
        public string RequestType { get; set; }
        public int? CashFlowTypeId { get; set; }
        public string CashFlowType { get; set; }
        public string AccountId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public string Error { get; set; }
        public string Organization { get; set; }
        public decimal? PaidSumm { get; set; }
        public DateTime Created { get; set; }
        public long? CheckRequestId { get; set; }
        public string TransactionNumber { get; set; }
        public string TransactionNumberStorno { get; set; }
        public string Comment { get; set; }
        public long? ReesterRecordId { get; set; }
        public string ReesterNumber { get; set; }
        public string RequestXml { get; set; }
        public long? PaymentAgentId { get; set; }
        public string PaymentOrganization { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
