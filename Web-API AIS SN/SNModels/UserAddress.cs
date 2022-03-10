using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserAddress
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long AdrId { get; set; }

        public virtual LocalAddress Adr { get; set; }
        public virtual User User { get; set; }
    }
}
