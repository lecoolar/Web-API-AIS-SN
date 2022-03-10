using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentExternalHouseParametersView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long ExternalHouseParameterId { get; set; }
        public string ApartmentNumber { get; set; }
        public string ApartmentAdrName { get; set; }
        public DateTime? Fromdate { get; set; }
        public DateTime? Todate { get; set; }
    }
}
