using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceTariffTypesView
    {
        public long Id { get; set; }
        public long? HouseServiceTariffId { get; set; }
        public decimal? HouseServiceTariffRate { get; set; }
        public DateTime? HouseServiceTariffFromDate { get; set; }
        public DateTime? HouseServiceTariffToDate { get; set; }
        public int TariffTypeId { get; set; }
        public string TariffTypeName { get; set; }
        public decimal? Rate { get; set; }
    }
}
