using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class SendChecksToEmail
    {
        public long Id { get; set; }
        public long SmsrPaysId { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
    }
}
