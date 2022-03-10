using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonBenefitOut
    {
        public long Id { get; set; }
        public DateTime? Period { get; set; }
        public long? PersonId { get; set; }
        public long? BenefitId { get; set; }
        public long? AccountId { get; set; }
        public decimal? Summ { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? ByPeriod { get; set; }
        public bool? IsDelete { get; set; }
        public string Comment { get; set; }
        public byte? IsDebt { get; set; }
        public byte? IsDebtPrev { get; set; }
    }
}
