using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountCashlessProperty
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long? OrgId { get; set; }
        public long? PersonId { get; set; }
        public string PrintName { get; set; }
        public string Number { get; set; }
        public string Subdivision { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual Account Account { get; set; }
        public virtual Organization1 Org { get; set; }
        public virtual Person Person { get; set; }
    }
}
