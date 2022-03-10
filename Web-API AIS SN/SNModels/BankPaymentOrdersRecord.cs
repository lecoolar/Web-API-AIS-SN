using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BankPaymentOrdersRecord
    {
        public BankPaymentOrdersRecord()
        {
            BankPaymentOrderRecordExternalProcessings = new HashSet<BankPaymentOrderRecordExternalProcessing>();
            BankPaymentOrderRecordJns = new HashSet<BankPaymentOrderRecordJn>();
            BankPaymentOrdersRecordAccounts = new HashSet<BankPaymentOrdersRecordAccount>();
        }

        public long Id { get; set; }
        public long BankPaymentOrdersId { get; set; }
        public string PaymentPayer { get; set; }
        public decimal? Summ { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Period { get; set; }
        public string AccountNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public string Apx { get; set; }
        public int StatusId { get; set; }
        public string Error { get; set; }
        public string BankAccountNumber { get; set; }
        public string ReesterNumber { get; set; }
        public string ExternalTransactionId { get; set; }
        public long? RequestId { get; set; }
        public string PaymentNumber { get; set; }
        public string PayerBank { get; set; }
        public string PayerBankBik { get; set; }
        public string PayerBankShortAccountNumber { get; set; }
        public long? AccountDocumentId { get; set; }
        public string NoticePaymentOrderNumber { get; set; }
        public long? NoticePaymentOrderId { get; set; }
        public string PaymentPayerInn { get; set; }
        public long? OrganizationId { get; set; }
        public string PaymentReceiver { get; set; }
        public string OrderName { get; set; }
        public long? PaymentOrderId { get; set; }
        public bool IsSend { get; set; }
        public int? OtherBankPaymentAttributeId { get; set; }
        public string PayerBankAccountNumber { get; set; }
        public long? GroupOperId { get; set; }
        public int? CashPaymentOrderType { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public string SubService { get; set; }
        public long? DebtActionId { get; set; }

        public virtual BankAccount ArrivalBankAccount { get; set; }
        public virtual BankPaymentOrder BankPaymentOrders { get; set; }
        public virtual DebtAction DebtAction { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual FasetItem OtherBankPaymentAttribute { get; set; }
        public virtual FasetItem Status { get; set; }
        public virtual ICollection<BankPaymentOrderRecordExternalProcessing> BankPaymentOrderRecordExternalProcessings { get; set; }
        public virtual ICollection<BankPaymentOrderRecordJn> BankPaymentOrderRecordJns { get; set; }
        public virtual ICollection<BankPaymentOrdersRecordAccount> BankPaymentOrdersRecordAccounts { get; set; }
    }
}
