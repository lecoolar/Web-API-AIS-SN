using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Budget
    {
        public Budget()
        {
            Laws = new HashSet<Law>();
        }

        public long Id { get; set; }
        public long OrgId { get; set; }
        public int BudgetFasetId { get; set; }

        public virtual FasetItem BudgetFaset { get; set; }
        public virtual Organization1 Org { get; set; }
        public virtual ICollection<Law> Laws { get; set; }
    }
}
