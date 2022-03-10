using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceTariff
    {
        public AccountServiceTariff()
        {
            AccountServiceTariffTypes = new HashSet<AccountServiceTariffType>();
        }

        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public decimal Rate { get; set; }
        public long? DocId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual OrgDocument Doc { get; set; }
        public virtual ICollection<AccountServiceTariffType> AccountServiceTariffTypes { get; set; }
    }
}
