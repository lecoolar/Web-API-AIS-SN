using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserOrganizationCommissionIgnore
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long OrganizationId { get; set; }
        public DateTime Created { get; set; }
    }
}
