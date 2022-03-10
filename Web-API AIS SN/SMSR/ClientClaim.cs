using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ClientClaim
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public virtual Client Client { get; set; }
    }
}
