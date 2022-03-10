using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReplicateJobPartialAccountService
    {
        public long Id { get; set; }
        public long JobPartialId { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
    }
}
