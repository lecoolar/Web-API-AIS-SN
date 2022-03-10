using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceCounter1
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long CounterId { get; set; }
        public decimal? Share { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public decimal? FactorConsumption { get; set; }
        public DateTime? OldTodate { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual ApartmentCounter Counter { get; set; }
    }
}
