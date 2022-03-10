using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebHistory
    {
        public int Id { get; set; }
        public long HouseAdrId { get; set; }
        public DateTime DateStart { get; set; }
        public decimal? TotalArea { get; set; }
    }
}
