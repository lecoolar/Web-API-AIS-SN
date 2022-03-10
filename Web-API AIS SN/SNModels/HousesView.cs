using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HousesView
    {
        public long Id { get; set; }
        public long AdrId { get; set; }
        public string AdrName { get; set; }
        public int? Type { get; set; }
        public string TypeName { get; set; }
        public int? Floor { get; set; }
        public int? Entrance { get; set; }
        public int? Lift { get; set; }
        public int? PassLift { get; set; }
        public int? CargoLift { get; set; }
        public int? HvsType { get; set; }
        public string HvsTypeName { get; set; }
        public int? GvsType { get; set; }
        public string GvsTypeName { get; set; }
        public int? GasType { get; set; }
        public string GasTypeName { get; set; }
        public int? SewerType { get; set; }
        public string SewerTypeName { get; set; }
        public int? StoveType { get; set; }
        public string StoveTypeName { get; set; }
        public int? WallType { get; set; }
        public string WallTypeName { get; set; }
        public int? YearBegin { get; set; }
        public int? Series { get; set; }
        public int? FormControl { get; set; }
        public string FormControlTypeName { get; set; }
        public int? OwnershipType { get; set; }
        public string OwnerShipTypeName { get; set; }
        public int? RoofType { get; set; }
        public string RoofTypeName { get; set; }
        public int? OverflowType { get; set; }
        public string OverFlowTypeName { get; set; }
        public int? HeatingType { get; set; }
        public string HeatingTypeName { get; set; }
        public int? UtilizationType { get; set; }
        public string UtilizationTypeName { get; set; }
        public int? LocalBroadcastingType { get; set; }
        public string LocalBroadcastingTypeName { get; set; }
        public int? TvenquipmentType { get; set; }
        public string TvenquipmentTypeName { get; set; }
        public int? FireAlarmType { get; set; }
        public string FireAlarmTypeName { get; set; }
        public int? CanonicalTypeId { get; set; }
        public string CanonicalTypeName { get; set; }
        public int? OverlapType { get; set; }
        public string OverlapTypeName { get; set; }
        public int? FoundationType { get; set; }
        public string FoundationTypeName { get; set; }
        public int? YearPassport { get; set; }
        public int? PercentWear { get; set; }
        public int? Flat { get; set; }
        public int? FlatWithGarbageChute { get; set; }
        public int? OneRoom { get; set; }
        public int? TwoRoom { get; set; }
        public int? ThreeRoom { get; set; }
        public int? FourRoom { get; set; }
        public int? FiveRoom { get; set; }
        public decimal? TotalStructuralVolume { get; set; }
        public decimal? TotalArea { get; set; }
        public decimal? FloorArea { get; set; }
        public decimal? FiredArea { get; set; }
        public decimal? LivingSquare { get; set; }
        public decimal? KitchensSquare { get; set; }
        public decimal? ToiletsSquare { get; set; }
        public decimal? AnotherSquare { get; set; }
        public int? BoroughId { get; set; }
        public string BoroughName { get; set; }
        public DateTime? OnDate { get; set; }
        public DateTime Created { get; set; }
        public string HouseChief { get; set; }
        public string SubProvider { get; set; }
        public bool? DomKom { get; set; }
        public int? Sud { get; set; }
        public string RaionSud { get; set; }
        public string SudUc { get; set; }
        public double? DomKomTarif { get; set; }
        public int? MusorCount { get; set; }
        public int? PassportNum { get; set; }
        public int? KapRemontYear { get; set; }
        public int PrintServices { get; set; }
        public int? TerritorialManagement { get; set; }
        public string TerritorialManagementName { get; set; }
        public bool? IsDistributePaymentInCurrentHouseHolder { get; set; }
        public long? ExternalKey { get; set; }
        public string Note { get; set; }
        public long? ObjectId { get; set; }
        public string HouseCodeFkr { get; set; }
        public long? KapRemMkdbankAccountOwnerOrgId { get; set; }
        public long? TerritorialBailiffDepartmentId { get; set; }
        public string TerritorialBailiffDepartmentName { get; set; }
        public int? GvssystemType { get; set; }
        public string GvssystemTypeName { get; set; }
        public long? SudUchatokOrgId { get; set; }
        public int? ImprovementWater { get; set; }
        public int? ImprovementHeat { get; set; }
        public string ImprovementWaterName { get; set; }
        public string ImprovementHeatName { get; set; }
    }
}
