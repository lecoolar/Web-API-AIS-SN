using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RenderedNoticesView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public long NoticeTemplateSettingId { get; set; }
        public string Barcode { get; set; }
        public long? HouseHolderId { get; set; }
        public string HouseHolderName { get; set; }
        public byte[] PacketReport { get; set; }
        public int? PageCount { get; set; }
        public bool HasResult { get; set; }
        public string AddressName { get; set; }
        public string HouseAddressName { get; set; }
        public string StreetName { get; set; }
        public string FlatSortValue { get; set; }
        public string HouseSortValue { get; set; }
        public int? PrintTypeId { get; set; }
        public string PrintTypeName { get; set; }
        public long? ParentId { get; set; }
        public long NoticeTemplateId { get; set; }
        public long? ActionId { get; set; }
        public string AccountCsv { get; set; }
        public string GeneralParams { get; set; }
    }
}
