using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseAreasView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long AdrId { get; set; }
        public string AdrName { get; set; }
        public DateTime FromDate { get; set; }
        public decimal? Total { get; set; }
        public decimal? Living { get; set; }
        public decimal? Heating { get; set; }
        public decimal? TotalMkd { get; set; }
        public decimal? LivingMkd { get; set; }
        public decimal? NotLivingMkd { get; set; }
        public decimal? TotalOi { get; set; }
        public decimal? Floor { get; set; }
        public decimal? NotSubscribe { get; set; }
        public DateTime Created { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentName { get; set; }
        public long? ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? ServiceCode { get; set; }
        public DateTime? ServiceFromDate { get; set; }
        public DateTime? ServiceToDate { get; set; }
    }
}
