using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class BankAccount
    {
        public long Id { get; set; }
        public string TypePayId { get; set; }
        public string NameAccount { get; set; }
        public string NamePid { get; set; }
        public string MerchantId { get; set; }
        public long OrgSnId { get; set; }
        public long OrgSnCode { get; set; }
        public string OrgName { get; set; }
        public string OrgFindName { get; set; }
        public int? CodePsservice { get; set; }

        public virtual TypePay TypePay { get; set; }
    }
}
