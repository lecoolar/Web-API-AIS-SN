using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ClientProperty
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public virtual Client Client { get; set; }
    }
}
