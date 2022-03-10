using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebAccount
    {
        public long RemoteAccountId { get; set; }
        public long? RemoteOrganizationId { get; set; }
        public string OrgShortName { get; set; }
        public string AccountNumber { get; set; }
        public DateTime DateStart { get; set; }
        public int? LivingPerson { get; set; }
        public decimal? TotalArea { get; set; }
        public decimal? ResidentialArea { get; set; }
        public decimal? HeatedArea { get; set; }
        public long RemoteHouseAddrId { get; set; }
        public long RemoteApartmentId { get; set; }
        public string ApartmentType { get; set; }
        public string ApartmentNumber { get; set; }
        public decimal? SharePercent { get; set; }
        public bool IsPayerIndividual { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }
        public long? RemotePayerOrganizationId { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public long? RemoteLocalAddressId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
