using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountConsumerGroupsView
    {
        public long AccountId { get; set; }
        public string L40Name { get; set; }
        public string L30Name { get; set; }
        public string L20Name { get; set; }
        public string L10Name { get; set; }
    }
}
