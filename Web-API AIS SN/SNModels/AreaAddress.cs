using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AreaAddress
    {
        public long Id { get; set; }
        public long AreaId { get; set; }
        public long AddressId { get; set; }

        public virtual LocalAddress Address { get; set; }
        public virtual Area Area { get; set; }
    }
}
