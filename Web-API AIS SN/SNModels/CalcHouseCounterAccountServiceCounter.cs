using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounterAccountServiceCounter
    {
        public long Id { get; set; }
        public long? CalcHouseCounterServiceId { get; set; }
        public long? AccountServiceCounterId { get; set; }
        public decimal? CounterVolume { get; set; }
        public decimal? Delta { get; set; }
        public decimal? Rate { get; set; }
        public long? AccountServiceId { get; set; }
        public long? CounterId { get; set; }
        public long? HouseCounterAccountServiceId { get; set; }
        public long? ApartmentAccountServiceId { get; set; }
        public bool? IsNonResidential { get; set; }
        public decimal? TotalSquare { get; set; }
        public decimal? Share { get; set; }
        public decimal? TotalResidentCount { get; set; }
        public string Formula { get; set; }
        public int? SquareChanges { get; set; }
        public decimal? NormOdn { get; set; }
        public decimal? CalcOdn { get; set; }
        public decimal? CounterVolumeDifferenceFromCp { get; set; }
        public decimal? ResidentCount { get; set; }
        public decimal? NormBigRate { get; set; }
        public decimal? BigRate { get; set; }
    }
}
