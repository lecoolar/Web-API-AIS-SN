using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Bank
    {
        public Bank()
        {
            ApartmentResidentBenefitProperties = new HashSet<ApartmentResidentBenefitProperty>();
            BankAccounts = new HashSet<BankAccount>();
        }

        public long Id { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Bik { get; set; }
        public decimal? LoroAccount { get; set; }
        public string City { get; set; }
        public string Info { get; set; }

        public virtual ICollection<ApartmentResidentBenefitProperty> ApartmentResidentBenefitProperties { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
    }
}
