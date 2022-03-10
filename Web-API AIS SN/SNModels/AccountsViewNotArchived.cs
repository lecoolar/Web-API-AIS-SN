using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountsViewNotArchived
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long AddrId { get; set; }
        public string AddressName { get; set; }
        public byte? AddressLevel { get; set; }
        public long? ParentAddrId { get; set; }
        public long? OwnerId { get; set; }
        public string OwnerName { get; set; }
        public bool? NeedOwnerPresence { get; set; }
        public string Comment { get; set; }
        public long? ClLs { get; set; }
        public long? ObjLs { get; set; }
        public long? PgCl { get; set; }
        public long? PgObj { get; set; }
        public DateTime ApartmentFromDate { get; set; }
        public DateTime? ApartmentToDate { get; set; }
        public DateTime ApartmentCreated { get; set; }
        public int? ApartmentFloorHouse { get; set; }
        public int? ApartmentDoorWay { get; set; }
        public byte? ApartmentRoomsCount { get; set; }
        public string ApartmentEnergoAccount { get; set; }
        public long? HouseHolderId { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderName { get; set; }
        public int? PersonAge { get; set; }
        public bool NeedPrintNotice { get; set; }
        public bool NeedEmailNotice { get; set; }
        public string IdentityCardNumber { get; set; }
        public string IdentityCardHolderName { get; set; }
        public string DocInfo { get; set; }
        public long? NoticeAdrId { get; set; }
        public string NoticeAddressName { get; set; }
        public string NoticeAdrName { get; set; }
        public string NoticeAdrPostalIndex { get; set; }
        public int? UseAccountServiceGroups { get; set; }
        public bool? IsCloseInPaymentSystem { get; set; }
        public bool? IsArchived { get; set; }
        public long? AdministrationDistrictId { get; set; }
        public string AdministrationDistrictName { get; set; }
        public long? OwnerOrgId { get; set; }
        public string BankAccountNumber { get; set; }
        public string NoticeEmail { get; set; }
        public int? TypeBudget { get; set; }
        public string TypeBudgetName { get; set; }
        public DateTime? DateComment { get; set; }
        public bool NeedSendAndPrintNotice { get; set; }
        public bool SetCounterIndicationWoauth { get; set; }
    }
}
