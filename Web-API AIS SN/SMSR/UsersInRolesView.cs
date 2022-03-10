using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class UsersInRolesView
    {
        public long? PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
