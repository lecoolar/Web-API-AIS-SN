using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitDebt
    {
        public long Id { get; set; }
        public long? PersonId { get; set; }
        public long? ServiceTypeId { get; set; }
        public DateTime? ValDate { get; set; }
        public DateTime? Created { get; set; }
        public decimal? Value { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? Period { get; set; }

        public virtual Person Person { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
