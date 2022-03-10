using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterNameView
    {
        public long? Id { get; set; }
        public long CounterId { get; set; }
        public string Name { get; set; }
        public string CounterName { get; set; }
        public string CounterTypeName { get; set; }
        public long AccountId { get; set; }
    }
}
