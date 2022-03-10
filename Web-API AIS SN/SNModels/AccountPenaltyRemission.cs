using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountPenaltyRemission
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime Created { get; set; }
        public bool? IsActive { get; set; }
        public long? DocId { get; set; }

        public virtual Account Account { get; set; }
        public virtual OrgDocument Doc { get; set; }
    }
}
