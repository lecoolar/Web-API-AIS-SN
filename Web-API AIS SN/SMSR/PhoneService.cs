using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PhoneService
    {
        public long Id { get; set; }
        public long? PhoneId { get; set; }
        public string Accpu { get; set; }
        public string TypePay { get; set; }
    }
}
