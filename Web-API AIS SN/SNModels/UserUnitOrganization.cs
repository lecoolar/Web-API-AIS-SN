using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserUnitOrganization
    {
        public long UserId { get; set; }
        public long OrganizationId { get; set; }

        public virtual Organization1 Organization { get; set; }
        public virtual User User { get; set; }
    }
}
