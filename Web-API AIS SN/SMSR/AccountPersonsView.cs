using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class AccountPersonsView
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public long PersonId { get; set; }
        public string PersonInn { get; set; }
        public string PersonSnils { get; set; }
    }
}
