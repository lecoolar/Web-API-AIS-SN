using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticesView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long AccountId { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentType { get; set; }
        public int? ResidentsCount { get; set; }
        public int? ResidentWithVacationsCount { get; set; }
        public long? HouseHolderId { get; set; }
        public string Barcode { get; set; }
        public string ApartmentTypeName { get; set; }
        public string OrgName { get; set; }
        public decimal? ToPay { get; set; }
        public string SubProvider { get; set; }
        public string HouseChief { get; set; }
        public decimal? ApartmentTotalSquare { get; set; }
        public decimal? ApartmentLivingSquare { get; set; }
        public decimal? HouseTotalSquare { get; set; }
        public string NoticeInformation { get; set; }
        public string ApartmentPropertys { get; set; }
        public bool IsClosedAllServices { get; set; }
        public bool PrintServices { get; set; }
        public bool IsGenerating { get; set; }
        public string HouseHolderName { get; set; }
        public long? HouseId { get; set; }
        public long AddrId { get; set; }
        public byte AddressLevel { get; set; }
        public long? ParentAddrId { get; set; }
        public string AddressName { get; set; }
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public string AdditionalInfo { get; set; }
        public string AlternativeAdditionalInfo { get; set; }
        public int? Version { get; set; }
    }
}
