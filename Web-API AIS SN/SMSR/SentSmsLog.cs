using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class SentSmsLog
    {
        public long Id { get; set; }
        public string SmsText { get; set; }
        public string RespondGate { get; set; }
        public long WebServiceId { get; set; }
        public DateTime? Created { get; set; }
        public string Gate { get; set; }
        public string Phone { get; set; }
    }
}
