using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcHouseCounterAccountServiceNormativ1
    {
        public long Id { get; set; }
        public long CalcNodeId { get; set; }
        public long TId { get; set; }
        public long? CalcHouseCounterServiceId { get; set; }
        public long? AccountServiceId { get; set; }
        public decimal? NormativVolume { get; set; }
        public decimal? ApartmentSquare { get; set; }
        public decimal? Delta { get; set; }
        public decimal? Charge { get; set; }
        public decimal? DeltaCharge { get; set; }
        public long? AccountId { get; set; }
        public long? HouseCounterAccountServiceId { get; set; }
        public long? ApartmentAccountServiceId { get; set; }
        public bool? IsNonResidential { get; set; }
        public decimal? Rate { get; set; }
        public decimal? TotalResidentCount { get; set; }
        public string Formula { get; set; }
        public int? SquareChanges { get; set; }
        public decimal? NormOdn { get; set; }
        public decimal? CalcOdn { get; set; }
        public decimal? NormativVolumeDifferenceFromCp { get; set; }
        public decimal? ResidentCount { get; set; }
    }
}
