using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseResourceProvidersView
    {
        public long Id { get; set; }
        public long ResourceProviderId { get; set; }
        public int ResourceProviderCode { get; set; }
        public string ResourceProviderName { get; set; }
        public long HouseId { get; set; }
        public long AddrId { get; set; }
        public string AddrName { get; set; }
        public long ServiceTypeId { get; set; }
        public int? ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
