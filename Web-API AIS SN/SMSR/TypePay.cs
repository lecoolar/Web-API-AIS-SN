using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class TypePay
    {
        public TypePay()
        {
            BankAccounts = new HashSet<BankAccount>();
            PaymentBases = new HashSet<PaymentBasis>();
            Pays = new HashSet<Pay>();
            ProviderInfos = new HashSet<ProviderInfo>();
        }

        public string TypePay1 { get; set; }
        public string CertName { get; set; }
        public string PathCert { get; set; }
        public string LongCertName { get; set; }
        public int? UserId { get; set; }
        public int? AgentId { get; set; }
        public string AddressBankPay { get; set; }
        public string CheckUrlBank { get; set; }
        public int PaymentAgentId { get; set; }
        public int Id { get; set; }
        public decimal? PersentCom { get; set; }
        public decimal? MinCom { get; set; }
        public bool HasBankComission { get; set; }
        public string Password { get; set; }
        public bool? Shluz { get; set; }
        public string Certhash { get; set; }
        public int? MaxCom { get; set; }
        public bool HasServiceComission { get; set; }
        public bool СonsiderBankComission { get; set; }

        public virtual PaymentAgent PaymentAgent { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<PaymentBasis> PaymentBases { get; set; }
        public virtual ICollection<Pay> Pays { get; set; }
        public virtual ICollection<ProviderInfo> ProviderInfos { get; set; }
    }
}
