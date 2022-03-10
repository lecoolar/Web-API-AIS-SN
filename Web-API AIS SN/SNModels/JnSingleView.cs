using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnSingleView
    {
        public long Id { get; set; }
        public long ProviderId { get; set; }
        public int? ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public long ServiceId { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCodeName { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime AccountServiceFromDate { get; set; }
        public DateTime? AccountServiceToDate { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public long? AccountOwnerId { get; set; }
        public string AccountOwnerName { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public long ApartmentAddrId { get; set; }
        public string ApartmentAddrName { get; set; }
        public long? ApartmentParentAddrId { get; set; }
        public long? HouseHolderId { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderName { get; set; }
        public byte CalcOperId { get; set; }
        public string CalcOperName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public decimal OriginalSumm { get; set; }
        public decimal? Summ { get; set; }
        public long? GroupOperId { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
    }
}
