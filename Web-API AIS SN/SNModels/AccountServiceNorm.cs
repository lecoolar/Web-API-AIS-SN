using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceNorm
    {
        public AccountServiceNorm()
        {
            AccountServiceNormTypes = new HashSet<AccountServiceNormType>();
        }

        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public decimal Rate { get; set; }
        public int UnitId { get; set; }
        public int? ByUnitId { get; set; }
        public long? DocId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual FasetItem ByUnit { get; set; }
        public virtual OrgDocument Doc { get; set; }
        public virtual FasetItem Unit { get; set; }
        public virtual ICollection<AccountServiceNormType> AccountServiceNormTypes { get; set; }
    }
}
