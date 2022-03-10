using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class RegistrationRequest
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Owner { get; set; }
        public string Email { get; set; }
        public string AccountNumber { get; set; }
        public decimal? RoomSpace { get; set; }
        public decimal? LastPay { get; set; }
        public byte? Confirmed { get; set; }
    }
}
