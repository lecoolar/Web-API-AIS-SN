using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LawsView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long BudgetId { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public int? BudgetFasetId { get; set; }
        public string BudgetFasetName { get; set; }
        public long? OrgId { get; set; }
        public string OrgName { get; set; }
    }
}
