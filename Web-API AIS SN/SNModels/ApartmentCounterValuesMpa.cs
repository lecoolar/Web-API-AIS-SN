using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterValuesMpa
    {
        public string AccNumber { get; set; }
        public string TypeName { get; set; }
        public int? Val { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public long? AcCl { get; set; }
        public long? AcObj { get; set; }
        public long CounterId { get; set; }
    }
}
