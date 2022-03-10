using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcPeriodsView
    {
        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string MonthName { get; set; }
        public int? Days { get; set; }
    }
}
