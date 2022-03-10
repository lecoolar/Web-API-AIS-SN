using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCountersServiceByDaysView
    {
        public long Id { get; set; }
        public long? AccountServiceId { get; set; }
        public long? AlgorithmId { get; set; }
        public long? ApartmentId { get; set; }
        public long ChcId { get; set; }
        public byte? DaysInPeriod { get; set; }
        public byte? DaysInRange { get; set; }
        public decimal? Delta { get; set; }
        public string Formula { get; set; }
        public decimal? HeatingSquare { get; set; }
        public decimal? HouseCounterVolume { get; set; }
        public string Number { get; set; }
        public long ServiceAccountId { get; set; }
        public int Code { get; set; }
        public string LongName { get; set; }
    }
}
