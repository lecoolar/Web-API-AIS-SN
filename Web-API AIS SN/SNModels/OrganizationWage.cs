using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationWage
    {
        public long Id { get; set; }
        public int ProfessionId { get; set; }
        public long Rank { get; set; }
        public long OrganizationId { get; set; }
        public decimal Wage { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime FromDate { get; set; }

        public virtual Organization1 Organization { get; set; }
        public virtual FasetItem Profession { get; set; }
    }
}
