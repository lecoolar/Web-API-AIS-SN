using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounterServicesByDay2
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long ChcId { get; set; }
        public DateTime Period { get; set; }
        public DateTime? ParamsPeriod { get; set; }
        public DateTime RangeStart { get; set; }
        public DateTime RangeEnd { get; set; }
        public string RangeStartReason { get; set; }
        public byte? DaysInRange { get; set; }
        public byte? DaysInPeriod { get; set; }
        public long? ApartmentId { get; set; }
        public long? AccountServiceId { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceTypeId { get; set; }
        public long? AlgorithmId { get; set; }
        public string Formula { get; set; }
        public string ProcName { get; set; }
        public int? ResidentsCount { get; set; }
        public int? ResidentVacationsCount { get; set; }
        public int? TotalResidentsCount { get; set; }
        public byte? NeedApartmentSquares { get; set; }
        public decimal? HeatingSquare { get; set; }
        public decimal? HouseCounterVolume { get; set; }
        public decimal? PersonalCountersVolume { get; set; }
        public decimal? NormativeVolume { get; set; }
        public decimal? SuspensionFactor { get; set; }
        public decimal? Delta { get; set; }
        public int? IsExistsApartmentCounter { get; set; }
    }
}
