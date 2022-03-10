using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Notice
    {
        public Notice()
        {
            NoticeCounters = new HashSet<NoticeCounter>();
            NoticeHouseCounters = new HashSet<NoticeHouseCounter>();
            NoticeNoticeAdditionalSettings = new HashSet<NoticeNoticeAdditionalSetting>();
            NoticeServices = new HashSet<NoticeService>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long AccountId { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentType { get; set; }
        public int? ResidentsCount { get; set; }
        public long? HouseHolderId { get; set; }
        public string Barcode { get; set; }
        public string ApartmentTypeName { get; set; }
        public string OrgName { get; set; }
        public decimal? ToPay { get; set; }
        public string SubProvider { get; set; }
        public string HouseChief { get; set; }
        public decimal? ApartmentTotalSquare { get; set; }
        public decimal? HouseTotalSquare { get; set; }
        public string NoticeInformation { get; set; }
        public string ApartmentPropertys { get; set; }
        public bool IsClosedAllServices { get; set; }
        public bool? PrintServices { get; set; }
        public long? HouseId { get; set; }
        public bool IsGenerating { get; set; }
        public int? ResidentWithVacationsCount { get; set; }
        public decimal? ApartmentLivingSquare { get; set; }
        public int? Version { get; set; }
        public long? HouseHolderBankAccountId { get; set; }
        public long? RicOrganizationId { get; set; }
        public long? OwnerOrganizationId { get; set; }
        public decimal? Debt { get; set; }
        public bool? IsExistAnySumm { get; set; }
        public int? CountersCount { get; set; }
        public decimal? FixedShowDebt { get; set; }
        public decimal? FilterMinDebt { get; set; }
        public int? NonResidential { get; set; }
        public int? HouseHolderBankAccountCode { get; set; }
        public int? PrintTypeId { get; set; }
        public bool? HouseHolderBankAccountIsPrimary { get; set; }
        public bool UseExternalNumber { get; set; }
        public string LocalDistrictName { get; set; }
        public long? RicBankAccountId { get; set; }
        public int? RicBankAccountCode { get; set; }
        public bool? RicBankAccountIsPrimary { get; set; }
        public decimal? HouseAreaTotal { get; set; }
        public decimal? HouseAreaLiving { get; set; }
        public decimal? HouseAreaHeating { get; set; }
        public decimal? HouseAreaTotalMkd { get; set; }
        public decimal? HouseAreaLivingMkd { get; set; }
        public decimal? HouseAreaNotLivingMkd { get; set; }
        public decimal? HouseAreaTotalOi { get; set; }
        public decimal? HouseAreaFloor { get; set; }
        public decimal? HouseAreaNotSubscribe { get; set; }
        public bool DisableGenerate { get; set; }
        public bool? CommunalApartment { get; set; }
        public bool? LinkedApartment { get; set; }
        public decimal? ApartmentHeatingSquare { get; set; }
        public int? BenefitResidentsCount { get; set; }
        public string WorkModeAddr { get; set; }
        public int? ResidentsRegisteredCount { get; set; }
        public int? ResidentsResideCount { get; set; }
        public int? ResidentsRegisteredTempCount { get; set; }
        public long? TerritorialSubdivisionId { get; set; }
        public long? ActionId { get; set; }
        public decimal? HouseAreaFloorEnergy { get; set; }
        public int? ApartmentOwnerCount { get; set; }
        public int? HouseResidentsCount { get; set; }
        public string ExternalNumber { get; set; }
        public long? AccountHouseHolderId { get; set; }
        public int? ResidentsRegisteredOnlyCount { get; set; }
        public int? ResidentsCheckInTempCount { get; set; }
        public decimal? HouseTotalNotLiveSquare { get; set; }
        public string PostalIndex { get; set; }
        public long? HouseBankAccountOrganizationAsRicOrgId { get; set; }
        public int? FloorCount { get; set; }
        public string AddressName { get; set; }
        public string AddressNameCityDistrict { get; set; }
        public string PostalIndexOriginal { get; set; }
        public int? ResidentsUnregisteredBenefit { get; set; }
        public long? TerritorialManageOrgId { get; set; }
        public long? CreatedActionId { get; set; }
        public int? ResidentInVacationsCount { get; set; }

        public virtual Action Action { get; set; }
        public virtual ICollection<NoticeCounter> NoticeCounters { get; set; }
        public virtual ICollection<NoticeHouseCounter> NoticeHouseCounters { get; set; }
        public virtual ICollection<NoticeNoticeAdditionalSetting> NoticeNoticeAdditionalSettings { get; set; }
        public virtual ICollection<NoticeService> NoticeServices { get; set; }
    }
}
