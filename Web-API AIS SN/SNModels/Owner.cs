using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Owner
    {
        public Owner()
        {
            Accounts = new HashSet<Account>();
            ApartmentOwners = new HashSet<ApartmentOwner>();
            BankAccounts = new HashSet<BankAccount>();
            DebtAffairOwners = new HashSet<DebtAffairOwner>();
            NonresidentialApartments = new HashSet<NonresidentialApartment>();
        }

        public long Id { get; set; }
        public long? PersonId { get; set; }
        public long? OrgId { get; set; }
        public int TypeOwner { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<ApartmentOwner> ApartmentOwners { get; set; }
        public virtual ICollection<BankAccount> BankAccounts { get; set; }
        public virtual ICollection<DebtAffairOwner> DebtAffairOwners { get; set; }
        public virtual ICollection<NonresidentialApartment> NonresidentialApartments { get; set; }
    }
}
