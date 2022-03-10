using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitDiffKszn
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public string Ls { get; set; }
        public string Family { get; set; }
        public string Name { get; set; }
        public string Father { get; set; }
        public string Street { get; set; }
        public string Lg { get; set; }
        public decimal? Summa { get; set; }
        public string Kszn { get; set; }
    }
}
