using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterIndicationsToRecalc
    {
        public long CounterIndicationId { get; set; }
        public bool IsError { get; set; }
        public string ErrorText { get; set; }
    }
}
