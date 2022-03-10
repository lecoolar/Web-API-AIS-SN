using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class UserSession
    {
        public long Id { get; set; }
        public long PhoneId { get; set; }
        public Guid? AccessToken { get; set; }
        public Guid? RefreshToken { get; set; }
        public DateTime ConnectionDate { get; set; }

        public virtual Phone Phone { get; set; }
    }
}
