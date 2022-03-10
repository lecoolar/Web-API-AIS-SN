using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class FiasNameWebServices2
    {
        public FiasNameWebServices2()
        {
            ApartmentLsNumberFias2s = new HashSet<ApartmentLsNumberFias2>();
        }

        public long Id { get; set; }
        public string Guid { get; set; }
        public string NameWebService { get; set; }

        public virtual ICollection<ApartmentLsNumberFias2> ApartmentLsNumberFias2s { get; set; }
    }
}
