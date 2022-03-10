using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountHouseHoldersView
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long OrgId { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public DateTime FromDate { get; set; }
    }
}
