using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaymentServiceView
    {
        public long Id { get; set; }
        public int ServiceCode { get; set; }
        public long WebServiceId { get; set; }
        public string BaseName { get; set; }
        public string TypeAction { get; set; }
        public long PaymentBaseId { get; set; }
        public int? UserId { get; set; }
        public string LongCertName { get; set; }
        public string TypePay { get; set; }
        public int? MinSummPaidForLk { get; set; }
        public int? MaxSummPaidForLk { get; set; }
        public bool? PaymentPage { get; set; }
        public string CertName { get; set; }
        public string AddressBankPay { get; set; }
        public string CheckUrlBank { get; set; }
        public string PathCert { get; set; }
        public string Name { get; set; }
        public int? BankCode { get; set; }
        public int PaymentAgentId { get; set; }
        public string PaymentAgentName { get; set; }
        public bool? Act { get; set; }
        public decimal? MinCom { get; set; }
        public int? MaxCom { get; set; }
        public decimal? PersentCom { get; set; }
        public bool? Regular { get; set; }
        public bool? GooglePay { get; set; }
        public bool? ApplePay { get; set; }
        public bool? SamsungPay { get; set; }
        public bool? Sbp { get; set; }
        public bool? Shluz { get; set; }
        public bool? HasBankComission { get; set; }
        public bool? СonsiderBankComission { get; set; }
        public bool? HasServiceComission { get; set; }
        public bool IsActive { get; set; }
    }
}
