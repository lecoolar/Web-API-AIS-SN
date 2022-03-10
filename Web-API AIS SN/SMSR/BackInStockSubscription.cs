using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class BackInStockSubscription
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
