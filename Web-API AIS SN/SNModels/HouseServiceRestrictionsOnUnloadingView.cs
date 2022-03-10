using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceRestrictionsOnUnloadingView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public string AddressName { get; set; }
        public long? ServiceId { get; set; }
        public int? ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public long? ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public long? ProviderId { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public long? OrgDocumentId { get; set; }
        public string OrgDocumentName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Created { get; set; }
    }
}
