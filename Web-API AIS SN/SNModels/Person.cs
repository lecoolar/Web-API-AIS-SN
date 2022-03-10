using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Person
    {
        public Person()
        {
            AccountCashlessProperties = new HashSet<AccountCashlessProperty>();
            AccountDebtorsInfoForRia = new HashSet<AccountDebtorsInfoForRia>();
            ApartmentRequests = new HashSet<ApartmentRequest>();
            ApartmentResidentBenefits = new HashSet<ApartmentResidentBenefit>();
            ApartmentResidents = new HashSet<ApartmentResident>();
            BenefitApartments = new HashSet<BenefitApartment>();
            BenefitDebts = new HashSet<BenefitDebt>();
            DebtAffairOwners = new HashSet<DebtAffairOwner>();
            JnBenefit1BenefitOwners = new HashSet<JnBenefit1>();
            JnBenefit1ExploitingPeople = new HashSet<JnBenefit1>();
            Owners = new HashSet<Owner>();
            PaymentMoreFixedSums = new HashSet<PaymentMoreFixedSum>();
            PersonBenefits = new HashSet<PersonBenefit>();
            PersonByOrganizations = new HashSet<PersonByOrganization>();
            PersonFamilyFromPeople = new HashSet<PersonFamily>();
            PersonFamilyToPeople = new HashSet<PersonFamily>();
            PersonProperties = new HashSet<PersonProperty>();
        }

        public long Id { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? TypeDoc { get; set; }
        public string SerDoc { get; set; }
        public string NumDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public string OrgDoc { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public byte IsDelete { get; set; }
        public string FullName { get; set; }
        public string InsuranceCertificate { get; set; }
        public string AccountBenefit { get; set; }
        public DateTime? DateBenefit { get; set; }
        public long? OrgBenefitId { get; set; }
        public bool IsUnknown { get; set; }
        public bool AllowPersonalDataUsage { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? DateChange { get; set; }
        public string Inn { get; set; }
        public string SubdivisionCodeDoc { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int? Sex { get; set; }

        public virtual Organization1 OrgBenefit { get; set; }
        public virtual FasetItem SexNavigation { get; set; }
        public virtual FasetItem TypeDocNavigation { get; set; }
        public virtual ICollection<AccountCashlessProperty> AccountCashlessProperties { get; set; }
        public virtual ICollection<AccountDebtorsInfoForRia> AccountDebtorsInfoForRia { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequests { get; set; }
        public virtual ICollection<ApartmentResidentBenefit> ApartmentResidentBenefits { get; set; }
        public virtual ICollection<ApartmentResident> ApartmentResidents { get; set; }
        public virtual ICollection<BenefitApartment> BenefitApartments { get; set; }
        public virtual ICollection<BenefitDebt> BenefitDebts { get; set; }
        public virtual ICollection<DebtAffairOwner> DebtAffairOwners { get; set; }
        public virtual ICollection<JnBenefit1> JnBenefit1BenefitOwners { get; set; }
        public virtual ICollection<JnBenefit1> JnBenefit1ExploitingPeople { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
        public virtual ICollection<PaymentMoreFixedSum> PaymentMoreFixedSums { get; set; }
        public virtual ICollection<PersonBenefit> PersonBenefits { get; set; }
        public virtual ICollection<PersonByOrganization> PersonByOrganizations { get; set; }
        public virtual ICollection<PersonFamily> PersonFamilyFromPeople { get; set; }
        public virtual ICollection<PersonFamily> PersonFamilyToPeople { get; set; }
        public virtual ICollection<PersonProperty> PersonProperties { get; set; }
    }
}
