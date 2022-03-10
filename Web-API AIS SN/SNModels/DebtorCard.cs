using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtorCard
    {
        public long Id { get; set; }
        public Guid DocsVisionCardGuid { get; set; }
        public long AccountId { get; set; }
        public long OrganizationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ClosedAt { get; set; }

        public virtual Account Account { get; set; }
        public virtual Organization1 Organization { get; set; }
    }
}
