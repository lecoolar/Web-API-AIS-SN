using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LoadAddrConformance
    {
        public long Id { get; set; }
        public long? ProcessingId { get; set; }
        public int? StatusId { get; set; }
        public long? BillId { get; set; }
        public long? SubDivId { get; set; }
        public DateTime? CalcPeriod { get; set; }
        public DateTime? UnloadDate { get; set; }
        public string Name { get; set; }
        public string PostalIndex { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string FiasHouse { get; set; }
        public string FiasParent { get; set; }
        public long? LocalDistrictId { get; set; }
        public long? CityId { get; set; }
        public long? StreetId { get; set; }
        public long? HouseId { get; set; }
        public string Comment { get; set; }
        public string Error { get; set; }
        public int? Code { get; set; }
        public long? ExtRecordId { get; set; }
    }
}
