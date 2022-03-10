using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LocalDistrict
    {
        public LocalDistrict()
        {
            LocalAddresses = new HashSet<LocalAddress>();
            NormsForTkos = new HashSet<NormsForTko>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public byte Level { get; set; }
        public string Code { get; set; }
        public long? DistrictAdministrationId { get; set; }
        public long? SupportDistrictId { get; set; }

        public virtual SupportToDistrict SupportDistrict { get; set; }
        public virtual ICollection<LocalAddress> LocalAddresses { get; set; }
        public virtual ICollection<NormsForTko> NormsForTkos { get; set; }
    }
}
