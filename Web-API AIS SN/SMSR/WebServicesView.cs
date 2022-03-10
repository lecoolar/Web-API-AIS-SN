using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class WebServicesView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string BaseName { get; set; }
        public string BaseIp { get; set; }
        public byte? Codedb { get; set; }
        public int? Srvnum { get; set; }
        public string Area { get; set; }
        public bool? CheckSumm { get; set; }
        public bool? IsSaveRecalcForIndications { get; set; }
        public bool? SetAgentComm { get; set; }
        public bool OpeningPayment { get; set; }
        public int? SrvnumKapRem { get; set; }
        public string SystemType { get; set; }
        public bool? IsLkactive { get; set; }
    }
}
