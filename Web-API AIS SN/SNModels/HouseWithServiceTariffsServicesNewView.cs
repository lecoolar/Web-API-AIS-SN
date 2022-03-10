using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseWithServiceTariffsServicesNewView
    {
        public long Id { get; set; }
        public long AdrId { get; set; }
        public string AdrName { get; set; }
        public long? TariffId { get; set; }
        public DateTime? TariffFromDate { get; set; }
        public DateTime? TariffToDate { get; set; }
        public decimal? TariffRate { get; set; }
        public long TariffServiceTypeId { get; set; }
        public string TariffServiceTypeName { get; set; }
        public long TariffServiceId { get; set; }
        public string TariffServiceName { get; set; }
        public int TariffServiceCode { get; set; }
        public long? NormId { get; set; }
        public DateTime? NormFromDate { get; set; }
        public decimal? NormRate { get; set; }
        public int? FloorCount { get; set; }
        public int? YearBuilt { get; set; }
        public int? CanonicalTypeId { get; set; }
        public string CanonicalTypeName { get; set; }
        public int? NormApartmentTypeId { get; set; }
        public string NormApartmentTypeName { get; set; }
        public int? NormUnitId { get; set; }
        public string NormUnitName { get; set; }
        public int? NormByUnitId { get; set; }
        public string NormByUnitName { get; set; }
        public decimal? NormFromValue { get; set; }
        public decimal? NormToValue { get; set; }
    }
}
