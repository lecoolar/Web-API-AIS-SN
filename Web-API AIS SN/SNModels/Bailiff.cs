using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Bailiff
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public DateTime? Date { get; set; }
        public long AddressId { get; set; }
        public decimal? Summ { get; set; }
    }
}
