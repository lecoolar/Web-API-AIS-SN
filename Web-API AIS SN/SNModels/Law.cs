using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Law
    {
        public Law()
        {
            BenefitLaws = new HashSet<BenefitLaw>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long BudgetId { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }

        public virtual Budget Budget { get; set; }
        public virtual ICollection<BenefitLaw> BenefitLaws { get; set; }
    }
}
