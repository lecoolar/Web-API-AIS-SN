using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnSumUploadedProvider
    {
        public long JnId { get; set; }
        public long ProviderId { get; set; }
        public DateTime Created { get; set; }

        public virtual Jn1 Jn { get; set; }
    }
}
