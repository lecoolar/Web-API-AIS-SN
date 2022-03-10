using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceNormsView
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public decimal Rate { get; set; }
        public int UnitId { get; set; }
        public int? ByUnitId { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string DocNumber { get; set; }
        public string UnitName { get; set; }
        public string ByUnitName { get; set; }
        public DateTime AccountServiceFromDate { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public int ServiceCode { get; set; }
        public string ShortName { get; set; }
    }
}
