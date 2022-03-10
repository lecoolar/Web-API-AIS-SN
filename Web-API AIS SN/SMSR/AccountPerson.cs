using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class AccountPerson
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
