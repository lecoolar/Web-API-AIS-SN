using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterAreasView
    {
        public long Id { get; set; }
        public long HouseCounterId { get; set; }
        public DateTime FromDate { get; set; }
        public decimal? Total { get; set; }
        public decimal? Living { get; set; }
        public decimal? Heating { get; set; }
        public decimal? TotalMkd { get; set; }
        public decimal? LivingMkd { get; set; }
        public decimal? NotLivingMkd { get; set; }
        public decimal? TotalOi { get; set; }
        public decimal? Floor { get; set; }
        public DateTime Created { get; set; }
        public long DocId { get; set; }
        public string OrgDocumentName { get; set; }
    }
}
