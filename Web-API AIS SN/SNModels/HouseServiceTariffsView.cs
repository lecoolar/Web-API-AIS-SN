using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceTariffsView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public int? ServiceTypeCode { get; set; }
        public long? ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? ServiceCode { get; set; }
        public DateTime? ServiceFromDate { get; set; }
        public DateTime? ServiceToDate { get; set; }
        public decimal Rate { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentTypeName { get; set; }
        public DateTime? OrgDocumentIssueDate { get; set; }
        public string OrgDocumentNumber { get; set; }
        public long? OrgId { get; set; }
        public string OrgName { get; set; }
        public int? OrgCode { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
