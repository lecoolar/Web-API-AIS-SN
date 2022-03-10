using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountOption
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long OptionId { get; set; }
        public int CountExecute { get; set; }
    }
}
