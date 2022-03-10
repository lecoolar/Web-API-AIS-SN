using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationPenaltiesSuspension
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long OrganizationId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal PenaltyPercent { get; set; }
        public long? DocId { get; set; }

        public virtual OrgDocument Doc { get; set; }
        public virtual Organization1 Organization { get; set; }
    }
}
