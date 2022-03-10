using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LoadAbonent
    {
        public long Id { get; set; }
        public long? ProcessingId { get; set; }
        public long? BillId { get; set; }
        public long? SubDivId { get; set; }
        public DateTime? CalcPeriod { get; set; }
        public DateTime? UnloadDate { get; set; }
        public string Number { get; set; }
        public string Fio { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string PostalIndex { get; set; }
        public string DistrictName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string FormControl { get; set; }
        public string TypeControl { get; set; }
        public string Total { get; set; }
        public string Living { get; set; }
        public string ResidentCount { get; set; }
        public string LiveCount { get; set; }
        public string HouseTotalArea { get; set; }
        public string HouseLivingArea { get; set; }
        public string HouseAllUsedArea { get; set; }
        public string PayUntilDate { get; set; }
        public string StateAbonent { get; set; }
        public string AltPostalIndex { get; set; }
        public string AltDistrictName { get; set; }
        public string AltCity { get; set; }
        public string AltStreet { get; set; }
        public string AltHouse { get; set; }
        public string AltFlat { get; set; }
        public string PersonBenefitCount { get; set; }
        public string YearBuildHouse { get; set; }
        public string FloorCount { get; set; }
        public string HouseLiveMkd { get; set; }
        public string TypeSpaceMkd { get; set; }
        public string TypeHouse { get; set; }
        public string FiasCode { get; set; }
        public string HaveExDoc { get; set; }
        public string SummExDoc { get; set; }
        public string ParentFiesCode { get; set; }
        public string IsEmployer { get; set; }
        public string Room { get; set; }
        public long? LocalDistrictId { get; set; }
        public long? CityId { get; set; }
        public long? StreetId { get; set; }
        public long? HouseId { get; set; }
        public long? FlatId { get; set; }
        public long? ApartmentId { get; set; }
        public long? AccountId { get; set; }
        public long? Ownerid { get; set; }
        public string Error { get; set; }
        public int? StatusId { get; set; }
        public string Comment { get; set; }
        public long? ExtRecordId { get; set; }
        public string EntranceCount { get; set; }
        public string RoomsCount { get; set; }
        public string ProvNumber { get; set; }
        public string PensCount { get; set; }
        public string SocialNormElectro { get; set; }
        public string ConsumerType { get; set; }
        public string GisGkhaccountNumber { get; set; }
        public string GisGkhgkunumber { get; set; }
    }
}
