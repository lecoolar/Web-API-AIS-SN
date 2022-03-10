using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HousePowerServiceEconomy
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public DateTime Period { get; set; }
        public decimal? EconomyResource { get; set; }
        public decimal? PayResource { get; set; }
        public decimal? PaySumm { get; set; }
    }
}
