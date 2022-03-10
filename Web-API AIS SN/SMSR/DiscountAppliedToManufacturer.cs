using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class DiscountAppliedToManufacturer
    {
        public int DiscountId { get; set; }
        public int ManufacturerId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
