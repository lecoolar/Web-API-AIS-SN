using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitAccount
    {
        public BenefitAccount()
        {
            JnBenefitAccounts = new HashSet<JnBenefitAccount>();
        }

        public long Id { get; set; }
        public DateTime Period { get; set; }
        public long? AccountId { get; set; }
        public string AccountNumber { get; set; }
        public Guid? Guid { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<JnBenefitAccount> JnBenefitAccounts { get; set; }
    }
}
