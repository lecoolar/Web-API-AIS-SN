using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalAddress
    {
        public LocalAddress()
        {
            Accounts = new HashSet<Account>();
            Apartment1s = new HashSet<Apartment1>();
            ApartmentTkoplatforms = new HashSet<ApartmentTkoplatform>();
            AreaAddresses = new HashSet<AreaAddress>();
            InverseParent = new HashSet<LocalAddress>();
            LocalAddressSynonymLocalAddresses = new HashSet<LocalAddressSynonym>();
            LocalAddressSynonymParentLocalAddresses = new HashSet<LocalAddressSynonym>();
            Organization1FactAdrs = new HashSet<Organization1>();
            Organization1JuridicAdrs = new HashSet<Organization1>();
            Organization1MailAdrs = new HashSet<Organization1>();
            Service1s = new HashSet<Service1>();
            ServiceTreaties = new HashSet<ServiceTreaty>();
            UserAddresses = new HashSet<UserAddress>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Socr { get; set; }
        public byte Level { get; set; }
        public long? ParentId { get; set; }
        public decimal? ClAdr { get; set; }
        public decimal? ObjAdr { get; set; }
        public string Adr { get; set; }
        public string PostalCode { get; set; }
        public string PostalIndex { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public long? LocalDistrictsId { get; set; }
        public bool UndefinedName { get; set; }
        public string FiasCode { get; set; }
        public string FiasName { get; set; }
        public string SocrDot { get; set; }
        public long? LocalDistrictsInCityId { get; set; }

        public virtual LocalDistrict LocalDistricts { get; set; }
        public virtual LocalDistrictsInCity LocalDistrictsInCity { get; set; }
        public virtual LocalAddress Parent { get; set; }
        public virtual CalcPeriodRestriction CalcPeriodRestriction { get; set; }
        public virtual House House { get; set; }
        public virtual NoticeInformationAddress1 NoticeInformationAddress1 { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Apartment1> Apartment1s { get; set; }
        public virtual ICollection<ApartmentTkoplatform> ApartmentTkoplatforms { get; set; }
        public virtual ICollection<AreaAddress> AreaAddresses { get; set; }
        public virtual ICollection<LocalAddress> InverseParent { get; set; }
        public virtual ICollection<LocalAddressSynonym> LocalAddressSynonymLocalAddresses { get; set; }
        public virtual ICollection<LocalAddressSynonym> LocalAddressSynonymParentLocalAddresses { get; set; }
        public virtual ICollection<Organization1> Organization1FactAdrs { get; set; }
        public virtual ICollection<Organization1> Organization1JuridicAdrs { get; set; }
        public virtual ICollection<Organization1> Organization1MailAdrs { get; set; }
        public virtual ICollection<Service1> Service1s { get; set; }
        public virtual ICollection<ServiceTreaty> ServiceTreaties { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
