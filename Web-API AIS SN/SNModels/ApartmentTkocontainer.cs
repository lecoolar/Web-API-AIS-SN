using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentTkocontainer
    {
        public long Id { get; set; }
        public long ApartmentTkoplatformId { get; set; }
        public decimal Volume { get; set; }
        public int Count { get; set; }

        public virtual ApartmentTkoplatform ApartmentTkoplatform { get; set; }
    }
}
