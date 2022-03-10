using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PhoneNotification
    {
        public long Id { get; set; }
        public long PhoneId { get; set; }
        public bool? IsSendWebApp { get; set; }
        public bool? IsSendMobileApp { get; set; }
        public bool? IsSendEmail { get; set; }
        public bool? IsSendViber { get; set; }
        public Guid Token { get; set; }
        public bool? ConfirmedSendEmail { get; set; }

        public virtual Phone Phone { get; set; }
    }
}
