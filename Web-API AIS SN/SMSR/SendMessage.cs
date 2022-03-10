using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class SendMessage
    {
        public long Id { get; set; }
        public string TextMessage { get; set; }
        public DateTime? Created { get; set; }
        public bool IsProcessStarted { get; set; }
        public bool IsProcessFinished { get; set; }
        public bool IsReplied { get; set; }
        public long? PhoneId { get; set; }
        public string Error { get; set; }
        public int? Priority { get; set; }
        public string QuerySmsId { get; set; }
        public string Phone { get; set; }
        public string Gate { get; set; }
        public string BaseName { get; set; }
        public long? WebServiceId { get; set; }
    }
}
