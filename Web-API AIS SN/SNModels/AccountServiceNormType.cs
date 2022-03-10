using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceNormType
    {
        public long Id { get; set; }
        public long AccountServiceNormId { get; set; }
        public int ApartmentPropertyId { get; set; }
        public decimal? Rate { get; set; }

        public virtual AccountServiceNorm AccountServiceNorm { get; set; }
        public virtual FasetItem ApartmentProperty { get; set; }
    }
}
