using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserServiceType
    {
        public long UserId { get; set; }
        public long ServiceTypeId { get; set; }

        public virtual ServiceType ServiceType { get; set; }
        public virtual User User { get; set; }
    }
}
