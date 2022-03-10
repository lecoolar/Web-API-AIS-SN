using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountProvider
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long ProviderId { get; set; }
        public string Number { get; set; }
        public DateTime Created { get; set; }
        public long? SubProviderId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string AccountNumberGis { get; set; }

        public virtual Account Account { get; set; }
        public virtual Organization1 Provider { get; set; }
        public virtual Organization1 SubProvider { get; set; }
    }
}
