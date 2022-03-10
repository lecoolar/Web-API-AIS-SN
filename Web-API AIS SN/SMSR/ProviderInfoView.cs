using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ProviderInfoView
    {
        public long Id { get; set; }
        public string TypePay { get; set; }
        public string ServiceName { get; set; }
        public long Code { get; set; }
        public string AgentName { get; set; }
        public int? BankCode { get; set; }
        public int? MinSummPaidForLk { get; set; }
        public int? MaxSumPayForLk { get; set; }
        public int TypePayId { get; set; }
        public string CertName { get; set; }
        public string PathCert { get; set; }
        public string LongCertName { get; set; }
        public int? UserId { get; set; }
        public int? AgentId { get; set; }
        public string AddressBankPay { get; set; }
        public string CheckUrlBank { get; set; }
        public int PaymentAgentId { get; set; }
        public decimal? PersentCom { get; set; }
        public decimal? MinCom { get; set; }
        public bool HasBankComission { get; set; }
        public string Password { get; set; }
        public bool? Shluz { get; set; }
        public string Certhash { get; set; }
        public bool? Regular { get; set; }
        public bool? ApplePay { get; set; }
        public bool? GooglePay { get; set; }
        public bool? SamsungPay { get; set; }
        public string ServiceIdentityName { get; set; }
        public bool IsActive { get; set; }
        public bool? Sbp { get; set; }
    }
}
