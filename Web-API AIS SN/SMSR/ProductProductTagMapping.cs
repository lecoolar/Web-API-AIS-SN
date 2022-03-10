using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ProductProductTagMapping
    {
        public int ProductId { get; set; }
        public int ProductTagId { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductTag ProductTag { get; set; }
    }
}
