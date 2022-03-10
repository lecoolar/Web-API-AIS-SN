using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class SendChecksToEmailView
    {
        public long Id { get; set; }
        public long SmsrPaysId { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
        public string StatusName { get; set; }
        public string Login { get; set; }
        public string AccountNumber { get; set; }
        public string TransactionNumber { get; set; }
        public string TypePay { get; set; }
    }
}
