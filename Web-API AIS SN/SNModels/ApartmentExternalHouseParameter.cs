using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentExternalHouseParameter
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long ExternalHouseParameterId { get; set; }
    }
}
