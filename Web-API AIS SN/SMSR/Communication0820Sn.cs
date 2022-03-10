using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Communication0820Sn
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string Number { get; set; }
        public long PhoneId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public long? BaseId { get; set; }
    }
}
