using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ApiScopeClaim
    {
        public int Id { get; set; }
        public int ApiScopeId { get; set; }
        public string Type { get; set; }

        public virtual ApiScope ApiScope { get; set; }
    }
}
