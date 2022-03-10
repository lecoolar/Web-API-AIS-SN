using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ShipmentItem
    {
        public int Id { get; set; }
        public int ShipmentId { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public int WarehouseId { get; set; }

        public virtual Shipment Shipment { get; set; }
    }
}
