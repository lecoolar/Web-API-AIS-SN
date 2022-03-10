using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountNumbersView
    {
        public long Id { get; set; }
        public long? NumberId { get; set; }
        public long? AccountId { get; set; }
        public string AccountNumber { get; set; }
    }
}
