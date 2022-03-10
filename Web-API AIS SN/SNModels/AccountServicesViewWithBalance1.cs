using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicesViewWithBalance1
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime AccountFromDate { get; set; }
        public DateTime? AccountToDate { get; set; }
        public DateTime AccountCreated { get; set; }
        public long? AccountKodCl { get; set; }
        public long? AccountKodObj { get; set; }
        public long? AccountOwnerId { get; set; }
        public string AccountOwnerName { get; set; }
        public long ServiceId { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceShortName { get; set; }
        public string ServiceLongName { get; set; }
        public DateTime ServiceFromDate { get; set; }
        public DateTime? ServiceToDate { get; set; }
        public long ServiceTypeId { get; set; }
        public int? ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
        public long? ServiceTypeParentId { get; set; }
        public decimal? ServiceNormRate { get; set; }
        public long ProviderId { get; set; }
        public int? OrgCode { get; set; }
        public string OrgName { get; set; }
        public long? CanonicalId { get; set; }
        public string CanonicalName { get; set; }
        public long? AlgorithmId { get; set; }
        public string AlgorithmName { get; set; }
        public int? CurrentRateId { get; set; }
        public decimal? CurrentRate { get; set; }
        public long? LastRateId { get; set; }
        public decimal? LastRate { get; set; }
        public long? HouseHolderId { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderShortName { get; set; }
        public string HouseHolderLongName { get; set; }
        public long? FinancialCenterId { get; set; }
        public int? FinancialCenterCode { get; set; }
        public string FinancialCenterShortName { get; set; }
        public string FinancialCenterLongName { get; set; }
        public long? ResourceProviderId { get; set; }
        public int? ResourceProviderCode { get; set; }
        public string ResourceProviderShortName { get; set; }
        public string ResourceProviderLongName { get; set; }
        public long? AdrId { get; set; }
        public string Adr { get; set; }
        public int? IsSeasonal { get; set; }
        public int? SeasonalCount { get; set; }
        public int IsFixedPayment { get; set; }
        public long? ClUsl { get; set; }
        public long? ObjUsl { get; set; }
        public string CounterCount { get; set; }
        public string CounterName { get; set; }
        public string EquipmentCount { get; set; }
        public decimal? SummCashlessPayments { get; set; }
        public DateTime? PeriodCashlessPayments { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public DateTime ApartmentFromDate { get; set; }
        public DateTime? ApartmentToDate { get; set; }
        public DateTime ApartmentCreated { get; set; }
        public long ApartmentAdrId { get; set; }
        public byte? ApartmentAddrLevel { get; set; }
        public string ApartmentAddrName { get; set; }
        public long? ApartmentParentAddrId { get; set; }
        public int? ApartmentFloorHouse { get; set; }
        public int? ApartmentDoorWay { get; set; }
        public byte? ApartmentRoomsCount { get; set; }
        public long? ApartmentKodCl { get; set; }
        public long? ApartmentKodObj { get; set; }
        public string ApartmentEnergoAccount { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public decimal? Balance { get; set; }
        public decimal? BalancePeni { get; set; }
        public string Guid { get; set; }
        public int UseAccountServiceGroups { get; set; }
        public string ServiceTypeGroupName { get; set; }
        public int ServiceTypeGroupCode { get; set; }
        public bool IsBankrupt { get; set; }
        public bool OpenedByError { get; set; }
        public long? OpenDocId { get; set; }
        public long? CloseDocId { get; set; }
        public string OpenDocOrgName { get; set; }
        public string CloseDocOrgName { get; set; }
        public bool? IsServiceBankrupt { get; set; }
        public int? ServiceApartmentTypeId { get; set; }
        public string ServiceApartmentTypeName { get; set; }
        public bool? IsTransferPaymentRestriction { get; set; }
        public string GeneralContractorShortName { get; set; }
        public string ExecutorGisName { get; set; }
        public DateTime? RecalcStartPeriod { get; set; }
        public string ProviderLongName { get; set; }
        public int? OffBalance { get; set; }
    }
}
