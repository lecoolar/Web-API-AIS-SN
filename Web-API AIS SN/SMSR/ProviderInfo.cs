using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ProviderInfo
    {
        public long Id { get; set; }
        public string TypePay { get; set; }
        public string Name { get; set; }
        public long Code { get; set; }
        public string ServiceIdentityName { get; set; }
        public bool IsActive { get; set; }

        public virtual TypePay TypePayNavigation { get; set; }
    }
}
