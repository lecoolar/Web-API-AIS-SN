using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterPlacesView
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public DateTime FromDate { get; set; }
        public int FasetItemId { get; set; }
        public string Name { get; set; }
    }
}
