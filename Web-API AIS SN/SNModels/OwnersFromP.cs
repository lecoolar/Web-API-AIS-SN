using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OwnersFromP
    {
        public string Adr { get; set; }
        public long? PsAddressId { get; set; }
        public long? SnAddressId { get; set; }
        public string AccountNumber { get; set; }
        public string Ownership { get; set; }
        public string Fio { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
