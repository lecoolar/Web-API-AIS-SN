using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterName
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public string Name { get; set; }

        public virtual ApartmentCounter Counter { get; set; }
    }
}
