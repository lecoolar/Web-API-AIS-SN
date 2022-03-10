using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceTariffTypeWithTariffsView
    {
        public long? Id { get; set; }
        public long HouseId { get; set; }
        public long ServiceTypeId { get; set; }
        public long? HouseServiceTariffId { get; set; }
        public long? HouseServiceTariffTypeId { get; set; }
        public int TariffTypeId { get; set; }
        public string TariffTypeName { get; set; }
        public decimal? Rate { get; set; }
    }
}
