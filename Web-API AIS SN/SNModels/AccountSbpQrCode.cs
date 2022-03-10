using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountSbpQrCode
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long OrgId { get; set; }
        public string SbpQrCode { get; set; }
        public string QrcId { get; set; }
    }
}
