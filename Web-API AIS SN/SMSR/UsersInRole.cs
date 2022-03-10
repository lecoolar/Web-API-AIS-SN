using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class UsersInRole
    {
        public long PhoneId { get; set; }
        public int RoleId { get; set; }

        public virtual Phone Phone { get; set; }
        public virtual Role Role { get; set; }
    }
}
