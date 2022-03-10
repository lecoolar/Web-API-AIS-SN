using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class DiscountAppliedToProduct
    {
        public int DiscountId { get; set; }
        public int ProductId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual Product Product { get; set; }
    }
}
