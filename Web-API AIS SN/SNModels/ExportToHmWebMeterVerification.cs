using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebMeterVerification
    {
        public DateTime Created { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateStart { get; set; }
        public decimal EndValueT1 { get; set; }
        public decimal? EndValueT2 { get; set; }
        public decimal? EndValueT3 { get; set; }
        public DateTime IsDeleted { get; set; }
        public string ReasonCode { get; set; }
        public long RemoteMeterId { get; set; }
        public long RemoteVerificationId { get; set; }
        public DateTime SealDate { get; set; }
        public decimal StartValueT1 { get; set; }
        public decimal? StartValueT2 { get; set; }
        public decimal? StartValueT3 { get; set; }
        public DateTime Updated { get; set; }
        public long? TransportMeterId { get; set; }
    }
}
