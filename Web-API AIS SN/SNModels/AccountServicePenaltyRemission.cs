using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicePenaltyRemission
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? GroupId { get; set; }
        public bool? IsActive { get; set; }
        public long? DocId { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual OrgDocument Doc { get; set; }
        public virtual GroupOperation Group { get; set; }
    }
}
