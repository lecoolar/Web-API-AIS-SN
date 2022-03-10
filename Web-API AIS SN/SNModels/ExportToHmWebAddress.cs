using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebAddress
    {
        public long HouseAdrId { get; set; }
        public string RegionName { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public string HouseName { get; set; }
        public decimal? SumApartmentAreaMunicipal { get; set; }
        public DateTimeOffset? Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public string Type { get; set; }
        public bool? IsDeleted { get; set; }
        public string FiasHouseGuid { get; set; }
        public string FiasGuid { get; set; }
        public decimal? SumHouseArea { get; set; }
        public decimal? SumApartmentAreaLiving { get; set; }
        public decimal? SumApartmentAreaNotLiving { get; set; }
        public decimal? NormWaterHeating { get; set; }
        public int? RiasObjectId { get; set; }
    }
}
