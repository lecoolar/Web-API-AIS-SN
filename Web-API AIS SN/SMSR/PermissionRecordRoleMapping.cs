using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PermissionRecordRoleMapping
    {
        public int PermissionRecordId { get; set; }
        public int CustomerRoleId { get; set; }

        public virtual CustomerRole CustomerRole { get; set; }
        public virtual PermissionRecord PermissionRecord { get; set; }
    }
}
