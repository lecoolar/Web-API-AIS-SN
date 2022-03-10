using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceProvidersView
    {
        public long Id { get; set; }
        public long ServiceProviderId { get; set; }
        public int ServiceProviderCode { get; set; }
        public string ServiceProviderName { get; set; }
        public long HouseId { get; set; }
        public long AddrId { get; set; }
        public string AddrName { get; set; }
        public long ServiceTypeId { get; set; }
        public int? ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? ServiceHouseHolderId { get; set; }
        public int? ServiceHouseHolderCode { get; set; }
        public string ServiceHouseHolderName { get; set; }
    }
}
