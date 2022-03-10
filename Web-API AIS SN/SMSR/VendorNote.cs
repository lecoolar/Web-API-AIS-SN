using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class VendorNote
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
