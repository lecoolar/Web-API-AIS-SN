using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CacheSnaccount
    {
        public long CacheId { get; set; }
        public long AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Cache Cache { get; set; }
    }
}
