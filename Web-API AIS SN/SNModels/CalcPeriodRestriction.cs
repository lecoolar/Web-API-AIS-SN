using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcPeriodRestriction
    {
        public long Id { get; set; }
        public long CalcPeriodId { get; set; }
        public long AddressId { get; set; }
        public long? ApartmentId { get; set; }

        public virtual LocalAddress Address { get; set; }
        public virtual CalcPeriod CalcPeriod { get; set; }
    }
}
