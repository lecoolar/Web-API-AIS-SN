using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class TempAccountPhonesViewSv1208
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public long PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public long WebServiceId { get; set; }
        public string BaseName { get; set; }
        public string BaseIp { get; set; }
        public string PersonInn { get; set; }
        public string PersonSnils { get; set; }
    }
}
