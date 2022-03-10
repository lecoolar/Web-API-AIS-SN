using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCountersByDay1
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long ChcId { get; set; }
        public DateTime Period { get; set; }
        public DateTime? ParamsPeriod { get; set; }
        public DateTime RangeStart { get; set; }
        public DateTime RangeEnd { get; set; }
        public byte? DaysInRange { get; set; }
        public byte? DaysInPeriod { get; set; }
        public int? HouseResidentsCount { get; set; }
        public int? HouseResidentVacationsCount { get; set; }
        public int? HouseTotalResidentsCount { get; set; }
        public decimal? HouseHeatingSquare { get; set; }
        public decimal? HouseCounterVolume { get; set; }
        public decimal? PersonalCountersVolume { get; set; }
        public decimal? NormativeVolume { get; set; }
        public int? IsExistsApartmentCounter { get; set; }
    }
}
