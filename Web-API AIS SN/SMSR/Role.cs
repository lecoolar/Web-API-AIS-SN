using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Role
    {
        public Role()
        {
            UsersInRoles = new HashSet<UsersInRole>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UsersInRole> UsersInRoles { get; set; }
    }
}
