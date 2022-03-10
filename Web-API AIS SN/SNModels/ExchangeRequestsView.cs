using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExchangeRequestsView
    {
        public long Id { get; set; }
        public string QueryId { get; set; }
        public string Guid { get; set; }
        public int Type { get; set; }
        public byte Status { get; set; }
        public decimal? AccountId { get; set; }
        public decimal? AddressId { get; set; }
        public string XmlIn { get; set; }
        public string XmlOut { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime? DateOut { get; set; }
        public string Dvnumber { get; set; }
        public DateTime? OperationDate { get; set; }
        public long? OutId { get; set; }
    }
}
