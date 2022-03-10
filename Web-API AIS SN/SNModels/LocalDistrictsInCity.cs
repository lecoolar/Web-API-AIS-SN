using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalDistrictsInCity
    {
        public LocalDistrictsInCity()
        {
            LocalAddresses = new HashSet<LocalAddress>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LocalAddress> LocalAddresses { get; set; }
    }
}
