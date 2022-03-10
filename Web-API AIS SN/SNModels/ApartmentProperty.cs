using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentProperty
    {
        public DateTime Period { get; set; }
        public long ApartmentId { get; set; }
        public int PropertyId { get; set; }
    }
}
