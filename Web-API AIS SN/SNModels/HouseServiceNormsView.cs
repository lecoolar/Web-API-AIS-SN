using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceNormsView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long? ServiceId { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTypeName { get; set; }
        public decimal Rate { get; set; }
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int? ByUnitId { get; set; }
        public string ByUnitName { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentTypeName { get; set; }
        public string OrgName { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? FromValue { get; set; }
        public decimal? ToValue { get; set; }
        public int AppartmentType { get; set; }
        public string AppartmentTypeName { get; set; }
    }
}
