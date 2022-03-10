using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Cache
    {
        public Cache()
        {
            CacheSnaccounts = new HashSet<CacheSnaccount>();
        }

        public long Id { get; set; }
        public string KeyHash { get; set; }
        public DateTime? Created { get; set; }
        public string AddKey { get; set; }
        public long? UserId { get; set; }

        public virtual ICollection<CacheSnaccount> CacheSnaccounts { get; set; }
    }
}
