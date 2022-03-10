using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountHouseHolder
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long OrgId { get; set; }
        public DateTime FromDate { get; set; }

        public virtual Account Account { get; set; }
        public virtual Organization1 Org { get; set; }
    }
}
