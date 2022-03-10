using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaymentBasesView
    {
        public int PaymentAgentId { get; set; }
        public long WebServiceId { get; set; }
        public string AgentName { get; set; }
        public int? BankCode { get; set; }
        public string BankCodeName { get; set; }
        public string BaseName { get; set; }
        public string WebServiceName { get; set; }
        public decimal? Persent { get; set; }
        public string TypePay { get; set; }
        public string CertName { get; set; }
        public string PathCert { get; set; }
        public string LongCertName { get; set; }
        public int? UserId { get; set; }
        public int? AgentId { get; set; }
        public string AddressBankPay { get; set; }
        public string CheckUrlBank { get; set; }
        public int? Srvnum { get; set; }
        public int? MinSummPaidForLk { get; set; }
        public string Password { get; set; }
        public bool? Regular { get; set; }
        public bool? GooglePay { get; set; }
        public bool? ApplePay { get; set; }
        public bool? SamsungPay { get; set; }
        public bool? Shluz { get; set; }
    }
}
