using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicesToRecalc
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Period { get; set; }
        public bool IsCalculated { get; set; }
        public DateTime Created { get; set; }
    }
}
