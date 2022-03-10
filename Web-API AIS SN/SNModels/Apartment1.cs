using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Apartment1
    {
        public Apartment1()
        {
            Accounts = new HashSet<Account>();
            ApartmentAreas = new HashSet<ApartmentArea>();
            ApartmentCanonicalTypes = new HashSet<ApartmentCanonicalType>();
            ApartmentCharacteristics = new HashSet<ApartmentCharacteristic>();
            ApartmentCountRooms = new HashSet<ApartmentCountRoom>();
            ApartmentCounterLinkages = new HashSet<ApartmentCounterLinkage>();
            ApartmentCounters = new HashSet<ApartmentCounter>();
            ApartmentEquipmentCounters = new HashSet<ApartmentEquipmentCounter>();
            ApartmentEquipmentHousekeepings = new HashSet<ApartmentEquipmentHousekeeping>();
            ApartmentEquipments = new HashSet<ApartmentEquipment>();
            ApartmentHouseHolder1s = new HashSet<ApartmentHouseHolder1>();
            ApartmentHousekeepings = new HashSet<ApartmentHousekeeping>();
            ApartmentLinkApartments = new HashSet<ApartmentLink>();
            ApartmentLinkChildren = new HashSet<ApartmentLink>();
            ApartmentMergeHistoryNextApartments = new HashSet<ApartmentMergeHistory>();
            ApartmentMergeHistoryPreviousApartments = new HashSet<ApartmentMergeHistory>();
            ApartmentNotes = new HashSet<ApartmentNote>();
            ApartmentOwners = new HashSet<ApartmentOwner>();
            ApartmentProperty1s = new HashSet<ApartmentProperty1>();
            ApartmentRequests = new HashSet<ApartmentRequest>();
            ApartmentResidentBenefits = new HashSet<ApartmentResidentBenefit>();
            ApartmentResidentVacations = new HashSet<ApartmentResidentVacation>();
            ApartmentResidents = new HashSet<ApartmentResident>();
            ApartmentTerritorialSubdivisions = new HashSet<ApartmentTerritorialSubdivision>();
            ApartmentTkoplatforms = new HashSet<ApartmentTkoplatform>();
            ApartmentTypes = new HashSet<ApartmentType>();
            ApartmentWorkTimeTables = new HashSet<ApartmentWorkTimeTable>();
            ApartmentWorkTimes = new HashSet<ApartmentWorkTime>();
            AreaApartments = new HashSet<AreaApartment>();
            BenefitApartments = new HashSet<BenefitApartment>();
            EntranceApartments = new HashSet<EntranceApartment>();
            HouseCounterApartments = new HashSet<HouseCounterApartment>();
        }

        public long Id { get; set; }
        public long? HouseId { get; set; }
        public string Number { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public long AdrId { get; set; }
        public int? FloorHouse { get; set; }
        public int? DoorWay { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public DateTime Datec { get; set; }
        public byte? RoomsCount { get; set; }
        public string EnergoAccount { get; set; }
        public string Phone { get; set; }
        public long? ToDateDocId { get; set; }
        public byte? FloorsCount { get; set; }
        public string TLoad { get; set; }
        public string Phone2 { get; set; }
        public string CadastralNumber { get; set; }
        public int? OkvedTypeId { get; set; }
        public int? ObjectCategoryId { get; set; }
        public decimal? VolumeTko { get; set; }

        public virtual LocalAddress Adr { get; set; }
        public virtual House House { get; set; }
        public virtual FasetItem ObjectCategory { get; set; }
        public virtual FasetItem OkvedType { get; set; }
        public virtual OrgDocument ToDateDoc { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<ApartmentArea> ApartmentAreas { get; set; }
        public virtual ICollection<ApartmentCanonicalType> ApartmentCanonicalTypes { get; set; }
        public virtual ICollection<ApartmentCharacteristic> ApartmentCharacteristics { get; set; }
        public virtual ICollection<ApartmentCountRoom> ApartmentCountRooms { get; set; }
        public virtual ICollection<ApartmentCounterLinkage> ApartmentCounterLinkages { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounters { get; set; }
        public virtual ICollection<ApartmentEquipmentCounter> ApartmentEquipmentCounters { get; set; }
        public virtual ICollection<ApartmentEquipmentHousekeeping> ApartmentEquipmentHousekeepings { get; set; }
        public virtual ICollection<ApartmentEquipment> ApartmentEquipments { get; set; }
        public virtual ICollection<ApartmentHouseHolder1> ApartmentHouseHolder1s { get; set; }
        public virtual ICollection<ApartmentHousekeeping> ApartmentHousekeepings { get; set; }
        public virtual ICollection<ApartmentLink> ApartmentLinkApartments { get; set; }
        public virtual ICollection<ApartmentLink> ApartmentLinkChildren { get; set; }
        public virtual ICollection<ApartmentMergeHistory> ApartmentMergeHistoryNextApartments { get; set; }
        public virtual ICollection<ApartmentMergeHistory> ApartmentMergeHistoryPreviousApartments { get; set; }
        public virtual ICollection<ApartmentNote> ApartmentNotes { get; set; }
        public virtual ICollection<ApartmentOwner> ApartmentOwners { get; set; }
        public virtual ICollection<ApartmentProperty1> ApartmentProperty1s { get; set; }
        public virtual ICollection<ApartmentRequest> ApartmentRequests { get; set; }
        public virtual ICollection<ApartmentResidentBenefit> ApartmentResidentBenefits { get; set; }
        public virtual ICollection<ApartmentResidentVacation> ApartmentResidentVacations { get; set; }
        public virtual ICollection<ApartmentResident> ApartmentResidents { get; set; }
        public virtual ICollection<ApartmentTerritorialSubdivision> ApartmentTerritorialSubdivisions { get; set; }
        public virtual ICollection<ApartmentTkoplatform> ApartmentTkoplatforms { get; set; }
        public virtual ICollection<ApartmentType> ApartmentTypes { get; set; }
        public virtual ICollection<ApartmentWorkTimeTable> ApartmentWorkTimeTables { get; set; }
        public virtual ICollection<ApartmentWorkTime> ApartmentWorkTimes { get; set; }
        public virtual ICollection<AreaApartment> AreaApartments { get; set; }
        public virtual ICollection<BenefitApartment> BenefitApartments { get; set; }
        public virtual ICollection<EntranceApartment> EntranceApartments { get; set; }
        public virtual ICollection<HouseCounterApartment> HouseCounterApartments { get; set; }
    }
}
