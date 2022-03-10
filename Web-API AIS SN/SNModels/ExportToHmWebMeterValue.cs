using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebMeterValue
    {
        public long RemoteMeterId { get; set; }
        public int IsCollectiveCounter { get; set; }
        public DateTime DateValue { get; set; }
        public decimal ValueT { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsControl { get; set; }
        public long? TransportMeterId { get; set; }
        public decimal? ValueT2 { get; set; }
        public decimal? ValueT3 { get; set; }
        public long? InputValueOrganizationId { get; set; }
    }
}
