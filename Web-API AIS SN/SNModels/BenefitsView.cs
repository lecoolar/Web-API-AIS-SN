using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitsView
    {
        public long Id { get; set; }
        public int Code { get; set; }
        public int? ExternalCode { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int? CalcFeature { get; set; }
        public string CalcFeatureName { get; set; }
        public int? IsAddress { get; set; }
        public int? BudgetTypeId { get; set; }
        public string BudgetTypeName { get; set; }
        public long? OrgId { get; set; }
        public string OrgName { get; set; }
        public long? LawId { get; set; }
        public string LawName { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public DateTime? MonetizationDate { get; set; }
    }
}
