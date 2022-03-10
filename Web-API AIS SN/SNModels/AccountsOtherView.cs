using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountsOtherView
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string Fio { get; set; }
        public string Phone { get; set; }
        public string Adr { get; set; }
        public string DocNumber { get; set; }
        public decimal OrgCommission { get; set; }
        public long ServiceProviderId { get; set; }
        public long OrgId { get; set; }
        public string OrgName { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public long? SnOrgId { get; set; }
        public string ServiceProviderName { get; set; }
        public long ServiceProviderInn { get; set; }
        public long ServiceProviderKpp { get; set; }
        public string ServiceProviderTelephone { get; set; }
        public string ServiceProviderBankName { get; set; }
        public string ServiceProviderBankCity { get; set; }
        public string ServiceProviderBankBik { get; set; }
        public decimal ServiceProviderBankLoro { get; set; }
        public decimal ServiceProviderBankAccountNumber { get; set; }
        public decimal? SumDebt { get; set; }
        public decimal? Saldo { get; set; }
        public long? CountByNumber { get; set; }
    }
}
