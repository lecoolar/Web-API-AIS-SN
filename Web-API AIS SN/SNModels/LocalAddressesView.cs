using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalAddressesView
    {
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
        public string LocalDistrictsName { get; set; }
        public string LocalDistrictsParentName { get; set; }
        public string FiasCode { get; set; }
        public string FiasName { get; set; }
        public string LocalUnionDistrictsName { get; set; }
        public long? LocalDistrictsInCityId { get; set; }
        public string LocalDistrictsInCityName { get; set; }
    }
}
