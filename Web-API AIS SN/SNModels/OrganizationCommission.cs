using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationCommission
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long OrganizationId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal Value { get; set; }
        public decimal? CommissionIncluding { get; set; }
        public decimal? CommissionCharge { get; set; }

        public virtual Organization1 Organization { get; set; }
    }
}
