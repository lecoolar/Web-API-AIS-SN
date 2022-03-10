using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BankPaymentOrder
    {
        public BankPaymentOrder()
        {
            BankPaymentOrdersRecords = new HashSet<BankPaymentOrdersRecord>();
            JnBankPaymentOrderOutputs = new HashSet<JnBankPaymentOrderOutput>();
        }

        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public string PaymentRecipient { get; set; }
        public string PaymentSender { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Created { get; set; }
        public int StatusId { get; set; }
        public string PaymentSystem { get; set; }
        public long? PaymentSystemId { get; set; }
        public string Organization { get; set; }
        public long? OrganizationId { get; set; }
        public long? UserId { get; set; }
        public int? BankTypeId { get; set; }
        public bool? IsInput { get; set; }
        public string OrderName { get; set; }
        public string Md5 { get; set; }
        public decimal? TotalReceivedSumm { get; set; }
        public decimal? TotalSendSumm { get; set; }
        public int CashPaymentOrderType { get; set; }
        public bool? IsPayCurrentReceipt { get; set; }

        public virtual FasetItem BankType { get; set; }
        public virtual FasetItem Status { get; set; }
        public virtual ICollection<BankPaymentOrdersRecord> BankPaymentOrdersRecords { get; set; }
        public virtual ICollection<JnBankPaymentOrderOutput> JnBankPaymentOrderOutputs { get; set; }
    }
}
