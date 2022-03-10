using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class WorkTimeTableTemplate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal? Monday { get; set; }
        public decimal? Tuesday { get; set; }
        public decimal? Wednesday { get; set; }
        public decimal? Thursday { get; set; }
        public decimal? Friday { get; set; }
        public decimal? Saturday { get; set; }
        public decimal? Sunday { get; set; }
    }
}
