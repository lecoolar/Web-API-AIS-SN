using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcPeriodRestrictionsView
    {
        public long Id { get; set; }
        public long CalcPeriodId { get; set; }
        public DateTime Period { get; set; }
        public long AddressId { get; set; }
    }
}
