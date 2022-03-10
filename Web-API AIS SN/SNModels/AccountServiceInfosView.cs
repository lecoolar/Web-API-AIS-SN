using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceInfosView
    {
        public string AccountNumber { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTypeName { get; set; }
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long ServiceId { get; set; }
        public long? HouseHolderId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string Guid { get; set; }
        public bool OpenedByError { get; set; }
        public long? OpenDocId { get; set; }
        public long? CloseDocId { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public DateTime AccountFromDate { get; set; }
        public DateTime? AccountToDate { get; set; }
        public long ProviderId { get; set; }
        public long? ServiceHouseHolderId { get; set; }
        public long AdrId { get; set; }
        public long? HouseId { get; set; }
    }
}
