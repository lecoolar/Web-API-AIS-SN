using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitDiffEsrn
    {
        public long Id { get; set; }
        public DateTime? Period { get; set; }
        public string Ls { get; set; }
        public string Family { get; set; }
        public string Name { get; set; }
        public string Father { get; set; }
        public string Street { get; set; }
        public int? Lg { get; set; }
        public int? Usl { get; set; }
        public decimal? Summa { get; set; }
        public string Prich { get; set; }
        public string FullName { get; set; }
        public bool? DontUse { get; set; }
    }
}
