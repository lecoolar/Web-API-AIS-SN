using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentHouseHolder
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long? HhId { get; set; }
        public DateTime Period { get; set; }
        public DateTime Created { get; set; }
    }
}
