using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ApiClaim
    {
        public int Id { get; set; }
        public int ApiResourceId { get; set; }
        public string Type { get; set; }

        public virtual ApiResource ApiResource { get; set; }
    }
}
