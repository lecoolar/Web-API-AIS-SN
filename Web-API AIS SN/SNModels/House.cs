using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class House
    {
        public House()
        {
            Apartment1s = new HashSet<Apartment1>();
            HouseAreas = new HashSet<HouseArea>();
            HouseBankAccounts = new HashSet<HouseBankAccount>();
            HouseBoilers = new HashSet<HouseBoiler>();
            HouseCanonicalTypes = new HashSet<HouseCanonicalType>();
            HouseCounter2s = new HashSet<HouseCounter2>();
            HouseEntrances = new HashSet<HouseEntrance>();
            HouseFormControls = new HashSet<HouseFormControl>();
            HouseGeneralContractors = new HashSet<HouseGeneralContractor>();
            HouseHouseHolders = new HashSet<HouseHouseHolder>();
            HouseOuterInformations = new HashSet<HouseOuterInformation>();
            HouseProperties = new HashSet<HouseProperty>();
            HouseResourceProviders = new HashSet<HouseResourceProvider>();
            HouseServiceNormBenefits = new HashSet<HouseServiceNormBenefit>();
            HouseServiceNorms = new HashSet<HouseServiceNorm>();
            HouseServiceProviders = new HashSet<HouseServiceProvider>();
            HouseServiceRestrictionsOnUnloadings = new HashSet<HouseServiceRestrictionsOnUnloading>();
            HouseServiceSeasons = new HashSet<HouseServiceSeason>();
            HouseServiceTariffs = new HashSet<HouseServiceTariff>();
            HouseTreatyCommitments = new HashSet<HouseTreatyCommitment>();
            NonresidentialApartments = new HashSet<NonresidentialApartment>();
        }

        public long Id { get; set; }
        public long AdrId { get; set; }
        public int? Type { get; set; }
        public int? Floor { get; set; }
        public int? Entrance { get; set; }
        public int? Lift { get; set; }
        public int? PassLift { get; set; }
        public int? CargoLift { get; set; }
        public int? HvsType { get; set; }
        public int? GvsType { get; set; }
        public int? SewerType { get; set; }
        public int? StoveType { get; set; }
        public int? WallType { get; set; }
        public int? YearBegin { get; set; }
        public int? Series { get; set; }
        public int? FormControl { get; set; }
        public int? OwnershipType { get; set; }
        public int? RoofType { get; set; }
        public int? OverflowType { get; set; }
        public int? HeatingType { get; set; }
        public int? UtilizationType { get; set; }
        public int? LocalBroadcastingType { get; set; }
        public int? TvenquipmentType { get; set; }
        public int? FireAlarmType { get; set; }
        public int? YearPassport { get; set; }
        public int? PercentWear { get; set; }
        public int? Flat { get; set; }
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
        public DateTime? OnDate { get; set; }
        public DateTime Created { get; set; }
        public int? BoroughId { get; set; }
        public long KodCl { get; set; }
        public long KodObj { get; set; }
        public string HouseChief { get; set; }
        public string SubProvider { get; set; }
        public int? PrintServices { get; set; }
        public int? CanonicalTypeId { get; set; }
        public int? FlatWithGarbageChute { get; set; }
        public int? OverlapType { get; set; }
        public int? FoundationType { get; set; }
        public bool? DomKom { get; set; }
        public int? Sud { get; set; }
        public string SudUc { get; set; }
        public double? DomKomTarif { get; set; }
        public int? MusorCount { get; set; }
        public int? PassportNum { get; set; }
        public int? KapRemontYear { get; set; }
        public int? TerritorialManagement { get; set; }
        public long? ExternalKey { get; set; }
        public bool? IsDistributePaymentInCurrentHouseHolder { get; set; }
        public string Note { get; set; }
        public long? ObjectId { get; set; }
        public long? KogKey { get; set; }
        public long? KzKey { get; set; }
        public string HouseCodeFkr { get; set; }
        public long? KapRemMkdbankAccountOwnerOrgId { get; set; }
        public long? IdQuantity { get; set; }
        public int? GasType { get; set; }
        public long? TerritorialBailiffDepartmentId { get; set; }
        public int? GvssystemType { get; set; }
        public long? SudUchatokOrgId { get; set; }
        public int? ImprovementWater { get; set; }
        public int? ImprovementHeat { get; set; }

        public virtual LocalAddress Adr { get; set; }
        public virtual FasetItem Borough { get; set; }
        public virtual FasetItem CanonicalType { get; set; }
        public virtual FasetItem FireAlarmTypeNavigation { get; set; }
        public virtual FasetItem FormControlNavigation { get; set; }
        public virtual FasetItem FoundationTypeNavigation { get; set; }
        public virtual FasetItem GvsTypeNavigation { get; set; }
        public virtual FasetItem GvssystemTypeNavigation { get; set; }
        public virtual FasetItem HeatingTypeNavigation { get; set; }
        public virtual FasetItem HvsTypeNavigation { get; set; }
        public virtual Organization1 KapRemMkdbankAccountOwnerOrg { get; set; }
        public virtual FasetItem LocalBroadcastingTypeNavigation { get; set; }
        public virtual FasetItem OverflowTypeNavigation { get; set; }
        public virtual FasetItem OverlapTypeNavigation { get; set; }
        public virtual FasetItem OwnershipTypeNavigation { get; set; }
        public virtual FasetItem RoofTypeNavigation { get; set; }
        public virtual FasetItem SewerTypeNavigation { get; set; }
        public virtual FasetItem StoveTypeNavigation { get; set; }
        public virtual FasetItem SudNavigation { get; set; }
        public virtual Organization1 TerritorialBailiffDepartment { get; set; }
        public virtual FasetItem TvenquipmentTypeNavigation { get; set; }
        public virtual FasetItem TypeNavigation { get; set; }
        public virtual FasetItem UtilizationTypeNavigation { get; set; }
        public virtual FasetItem WallTypeNavigation { get; set; }
        public virtual ICollection<Apartment1> Apartment1s { get; set; }
        public virtual ICollection<HouseArea> HouseAreas { get; set; }
        public virtual ICollection<HouseBankAccount> HouseBankAccounts { get; set; }
        public virtual ICollection<HouseBoiler> HouseBoilers { get; set; }
        public virtual ICollection<HouseCanonicalType> HouseCanonicalTypes { get; set; }
        public virtual ICollection<HouseCounter2> HouseCounter2s { get; set; }
        public virtual ICollection<HouseEntrance> HouseEntrances { get; set; }
        public virtual ICollection<HouseFormControl> HouseFormControls { get; set; }
        public virtual ICollection<HouseGeneralContractor> HouseGeneralContractors { get; set; }
        public virtual ICollection<HouseHouseHolder> HouseHouseHolders { get; set; }
        public virtual ICollection<HouseOuterInformation> HouseOuterInformations { get; set; }
        public virtual ICollection<HouseProperty> HouseProperties { get; set; }
        public virtual ICollection<HouseResourceProvider> HouseResourceProviders { get; set; }
        public virtual ICollection<HouseServiceNormBenefit> HouseServiceNormBenefits { get; set; }
        public virtual ICollection<HouseServiceNorm> HouseServiceNorms { get; set; }
        public virtual ICollection<HouseServiceProvider> HouseServiceProviders { get; set; }
        public virtual ICollection<HouseServiceRestrictionsOnUnloading> HouseServiceRestrictionsOnUnloadings { get; set; }
        public virtual ICollection<HouseServiceSeason> HouseServiceSeasons { get; set; }
        public virtual ICollection<HouseServiceTariff> HouseServiceTariffs { get; set; }
        public virtual ICollection<HouseTreatyCommitment> HouseTreatyCommitments { get; set; }
        public virtual ICollection<NonresidentialApartment> NonresidentialApartments { get; set; }
    }
}
