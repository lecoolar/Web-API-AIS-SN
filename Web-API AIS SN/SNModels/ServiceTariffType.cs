using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTariffType
    {
        public long Id { get; set; }
        public long? ServiceTariffId { get; set; }
        public int TariffTypeId { get; set; }
        public decimal? Rate { get; set; }

        public virtual ServiceTariff ServiceTariff { get; set; }
        public virtual FasetItem TariffType { get; set; }
    }
}
