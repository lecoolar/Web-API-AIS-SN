using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebRate
    {
        public string RegionName { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public string HouseName { get; set; }
        public long? HouseAdrId { get; set; }
        public string ServiceName { get; set; }
        public string TypeName { get; set; }
        public string TypeParentName { get; set; }
        public long? ProviderInn { get; set; }
        public string ProviderName { get; set; }
        public long? HouseHolderInn { get; set; }
        public string HouseHolderName { get; set; }
        public string TypeUnitName { get; set; }
        public decimal? NormRate { get; set; }
        public decimal? NormValue { get; set; }
        public string NormUnitName { get; set; }
        public bool? NormIsPerHuman { get; set; }
    }
}
