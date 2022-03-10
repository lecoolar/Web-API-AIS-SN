using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BankPaymentOrdersRecordsView
    {
        public long Id { get; set; }
        public long BankPaymentOrdersId { get; set; }
        public string BankPaymentOrdersName { get; set; }
        public string PaymentNumber { get; set; }
        public string PaymentPayer { get; set; }
        public string PaymentPayerInn { get; set; }
        public string PaymentReceiver { get; set; }
        public decimal? Summ { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Period { get; set; }
        public string AccountNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public string Apx { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string Error { get; set; }
        public string BankAccountNumber { get; set; }
        public string ExternalTransactionId { get; set; }
        public long? RequestId { get; set; }
        public string PayerBank { get; set; }
        public string PayerBankAccountNumber { get; set; }
        public string PayerBankBik { get; set; }
        public string PayerBankShortAccountNumber { get; set; }
        public bool IsSend { get; set; }
        public long? AccountDocumentId { get; set; }
        public string AccountDocumentNumber { get; set; }
        public string NoticePaymentOrderNumber { get; set; }
        public long? NoticePaymentOrderId { get; set; }
        public long? OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public string OrderName { get; set; }
        public string ReesterNumber { get; set; }
        public long? PaymentOrderId { get; set; }
        public string PaymentOrderNumber { get; set; }
        public long? PaymentOrderMainId { get; set; }
        public decimal? PaymentOrderDeltaSumm { get; set; }
        public int? OtherBankPaymentAttributeId { get; set; }
        public string OtherBankPaymentAttributeName { get; set; }
        public int? CashPaymentOrderType { get; set; }
        public long? GroupOperId { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public string SubService { get; set; }
        public long? DebtActionId { get; set; }
        public string DebtActionCourtProcessNumber { get; set; }
    }
}
