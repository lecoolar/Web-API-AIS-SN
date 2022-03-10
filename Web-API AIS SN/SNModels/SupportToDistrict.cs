using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SupportToDistrict
    {
        public SupportToDistrict()
        {
            LocalDistricts = new HashSet<LocalDistrict>();
        }

        public long Id { get; set; }
        public string Fio { get; set; }
        public string Email { get; set; }

        public virtual ICollection<LocalDistrict> LocalDistricts { get; set; }
    }
}
