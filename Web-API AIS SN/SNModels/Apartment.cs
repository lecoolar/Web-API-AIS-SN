using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Apartment
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? HouseHolderId { get; set; }
        public string HouseHolderName { get; set; }
        public long? HouseHolderParentId { get; set; }
        public string HouseHolderParentName { get; set; }
        public long? AddrId { get; set; }
        public string AddrName { get; set; }
        public string Flat { get; set; }
        public string House { get; set; }
        public string Street { get; set; }
        public long? OwnerId { get; set; }
        public string OwnerName { get; set; }
        public long? FasetApartmentTypeId { get; set; }
        public string FasetApartmentTypeName { get; set; }
        public int? HouseFloors { get; set; }
        public int? Floor { get; set; }
        public int? DoorWay { get; set; }
        public int? RoomsCount { get; set; }
        public int? BathsCount { get; set; }
        public int? HothousesCount { get; set; }
        public int? GaragesCount { get; set; }
        public int? WaterHeatersCount { get; set; }
        public int? HeatingCoppersCount { get; set; }
        public int? GasPlatesCount { get; set; }
        public int? ElectricPlatesCount { get; set; }
        public decimal? GarageSquare { get; set; }
        public decimal? HothousesSquare { get; set; }
        public int? HorsesCount { get; set; }
        public int? LargeCattleCount { get; set; }
        public int? ShallowCattleCount { get; set; }
        public int? PigsCount { get; set; }
        public int? ResidentsCount { get; set; }
        public decimal? TotalSquare { get; set; }
        public decimal? HeatingSquare { get; set; }
        public decimal? BalconySquare { get; set; }
        public int? HasHotWater { get; set; }
        public int? IsCommunal { get; set; }
        public int? PersonBenefitsCount { get; set; }
        public string City { get; set; }
        public int? ResidentDaysCount { get; set; }
        public int? ResidentVacationDaysCount { get; set; }
        public int? CreatedResidentVacationDaysCount { get; set; }
        public int? OnLastDayMonthResidentsCount { get; set; }
        public decimal? LivingSquare { get; set; }
        public int? ConvenienceTypeId { get; set; }
        public string ConvenienceTypeName { get; set; }
        public DateTime Created { get; set; }
        public int? ResidentVacationsCount { get; set; }
        public long? FasetHouseTypeId { get; set; }
        public string FasetHouseTypeName { get; set; }
        public long? UserId { get; set; }
        public string CitySocr { get; set; }
        public string StreetSocr { get; set; }
        public string HouseSocr { get; set; }
        public string FlatSocr { get; set; }
    }
}
