using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceTariffNormView
    {
        public long Id { get; set; }
        public long TariffServiceTypeId { get; set; }
        public string TariffServiceTypeName { get; set; }
        public long? AdrId { get; set; }
        public string AdrName { get; set; }
        public long AccountServiceId { get; set; }
        public long? TariffId { get; set; }
        public decimal? RateTariff { get; set; }
        public DateTime? TariffFromDate { get; set; }
        public long? NormId { get; set; }
        public decimal? RateNorm { get; set; }
        public DateTime? NormFromDate { get; set; }
        public int? NormUnitId { get; set; }
        public int? NormByUnitId { get; set; }
        public long? ApartmentId { get; set; }
        public string AccountNumber { get; set; }
    }
}
