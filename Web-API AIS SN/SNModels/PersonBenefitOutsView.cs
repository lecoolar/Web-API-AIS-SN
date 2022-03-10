using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonBenefitOutsView
    {
        public long Id { get; set; }
        public DateTime? Period { get; set; }
        public long? PersonId { get; set; }
        public string PersonName { get; set; }
        public long? BenefitId { get; set; }
        public string BenefitCode { get; set; }
        public string BenefitName { get; set; }
        public long? AccountId { get; set; }
        public string AccountNumber { get; set; }
        public decimal? Summ { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? ByPeriod { get; set; }
        public bool? IsDelete { get; set; }
        public string Comment { get; set; }
    }
}
