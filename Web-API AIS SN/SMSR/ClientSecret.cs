using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ClientSecret
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Description { get; set; }
        public DateTime? Expiration { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public virtual Client Client { get; set; }
    }
}
