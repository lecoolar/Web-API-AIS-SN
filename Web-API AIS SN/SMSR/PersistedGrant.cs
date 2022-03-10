using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PersistedGrant
    {
        public string Key { get; set; }
        public string ClientId { get; set; }
        public DateTime CreationTime { get; set; }
        public string Data { get; set; }
        public DateTime? Expiration { get; set; }
        public string SubjectId { get; set; }
        public string Type { get; set; }
    }
}
