using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class AclRecord
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public int CustomerRoleId { get; set; }

        public virtual CustomerRole CustomerRole { get; set; }
    }
}
