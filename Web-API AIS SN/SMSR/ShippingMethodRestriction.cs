using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ShippingMethodRestriction
    {
        public int ShippingMethodId { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ShippingMethod ShippingMethod { get; set; }
    }
}
