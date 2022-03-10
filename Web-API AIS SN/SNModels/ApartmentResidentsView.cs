using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentName { get; set; }
        public long PersonId { get; set; }
        public string PersonName { get; set; }
        public bool AllowPersonalDataUsage { get; set; }
        public int? TypeResidents { get; set; }
        public string TypeResidentName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Relative { get; set; }
        public string RelativeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string InsuranceCertificate { get; set; }
        public string AccountBenefit { get; set; }
        public int? Age { get; set; }
        public bool IsUnknown { get; set; }
        public long ApartmentLocalAddressId { get; set; }
        public string Comment { get; set; }
        public DateTime? DateChange { get; set; }
        public int? IsTransferedPasport { get; set; }
        public long? Userid { get; set; }
        public string Userlogin { get; set; }
        public string Username { get; set; }
    }
}
