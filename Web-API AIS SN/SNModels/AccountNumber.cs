using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountNumber
    {
        public long Id { get; set; }
        public long? NumberId { get; set; }
        public long? AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Number Number { get; set; }
    }
}
