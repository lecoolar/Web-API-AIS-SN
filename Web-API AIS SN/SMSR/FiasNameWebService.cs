using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class FiasNameWebService
    {
        public FiasNameWebService()
        {
            ApartmentLsNumberFia = new HashSet<ApartmentLsNumberFia>();
        }

        public long Id { get; set; }
        public Guid Guid { get; set; }
        public string NameWebService { get; set; }

        public virtual ICollection<ApartmentLsNumberFia> ApartmentLsNumberFia { get; set; }
    }
}
