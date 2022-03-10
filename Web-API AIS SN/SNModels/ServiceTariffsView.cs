using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTariffsView
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public decimal Rate { get; set; }
        public decimal? SuperRate { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentName { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public DateTime ServiceFromDate { get; set; }
        public DateTime? ServiceToDate { get; set; }
        public long ProviderId { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public long? HouseHolderId { get; set; }
        public string HouseHolderName { get; set; }
        public string AdrName { get; set; }
        public long? CanonicalId { get; set; }
        public string CanonicalName { get; set; }
    }
}
