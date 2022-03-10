using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Run
    {
        public long AccountServiceId { get; set; }
        public DateTime? Period { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Saldo { get; set; }
        public DateTime? Created { get; set; }
        public int? Baseimport { get; set; }
    }
}
