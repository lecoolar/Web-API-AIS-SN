using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserUpdate
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime DateUpdate { get; set; }
        public bool? FullPermisson { get; set; }

        public virtual User User { get; set; }
    }
}
