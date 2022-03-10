using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceNormsView
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public decimal Rate { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int? ByUnitId { get; set; }
        public string ByUnitName { get; set; }
        public long? DocId { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? FromValue { get; set; }
        public decimal? ToValue { get; set; }
        public string AppartmentType { get; set; }
    }
}
