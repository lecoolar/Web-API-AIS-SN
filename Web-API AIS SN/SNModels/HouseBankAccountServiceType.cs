using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseBankAccountServiceType
    {
        public long Id { get; set; }
        public long HouseBankAccountId { get; set; }
        public DateTime Created { get; set; }
        public long ServiceId { get; set; }

        public virtual HouseBankAccount HouseBankAccount { get; set; }
        public virtual Service1 Service { get; set; }
    }
}
