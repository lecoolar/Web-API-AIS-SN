using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class LogsView
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountOwnerName { get; set; }
        public long? AccountWebServiceId { get; set; }
        public string AccountWebServiceName { get; set; }
        public string AccountWebServiceUrl { get; set; }
        public long? QueryTypeId { get; set; }
        public long? PhoneId { get; set; }
        public string Phone { get; set; }
        public int? QueryTypeCode { get; set; }
        public string QueryTypeShortName { get; set; }
        public string QueryTypeLongName { get; set; }
        public string InMessage { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? OutDate { get; set; }
        public bool IsProcessStarted { get; set; }
        public bool IsProcessFinished { get; set; }
        public bool IsReplied { get; set; }
        public string Error { get; set; }
        public string Gate { get; set; }
        public DateTime Created { get; set; }
    }
}
