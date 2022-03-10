using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceTariffType
    {
        public long Id { get; set; }
        public long AccountServiceTariffId { get; set; }
        public int TariffTypeId { get; set; }
        public decimal? Rate { get; set; }

        public virtual AccountServiceTariff AccountServiceTariff { get; set; }
        public virtual FasetItem TariffType { get; set; }
    }
}
