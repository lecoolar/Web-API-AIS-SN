using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounterAccountServiceNonResidential
    {
        public long Id { get; set; }
        public long? CalcHouseCounterServiceId { get; set; }
        public long? NonResidentialApartmentId { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Delta { get; set; }
        public long? ApartmentId { get; set; }
        public decimal? ApartmentSquare { get; set; }
        public decimal? Rate { get; set; }
    }
}
