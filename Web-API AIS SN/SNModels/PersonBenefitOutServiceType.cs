using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonBenefitOutServiceType
    {
        public long Id { get; set; }
        public long? PersonBenefitOutId { get; set; }
        public long? ServiceTypeId { get; set; }
        public decimal? Summ { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? ByPeriod { get; set; }
        public bool? IsDelete { get; set; }
    }
}
