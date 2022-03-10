using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentsViewUi
    {
        public long Id { get; set; }
        public long? HouseId { get; set; }
        public string Number { get; set; }
        public int? FloorHouse { get; set; }
        public int? DoorWay { get; set; }
        public byte? RoomsCount { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long AdrId { get; set; }
        public string AddressName { get; set; }
        public byte? AddressLevel { get; set; }
        public long? ParentAddrId { get; set; }
        public string AccountNumber { get; set; }
        public long? OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string EnergoAccount { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public long? ToDateDocId { get; set; }
        public int? PersonAge { get; set; }
        public DateTime? AccountCreatedDate { get; set; }
        public DateTime? AccountToDate { get; set; }
        public byte? FloorsCount { get; set; }
        public long? OwnerOrgId { get; set; }
        public decimal? TotalSquare { get; set; }
        public string CadastralNumber { get; set; }
        public int? OkvedTypeId { get; set; }
        public string OkvedTypeName { get; set; }
        public int? ObjectCategoryId { get; set; }
        public string ObjectCategoryName { get; set; }
        public decimal? VolumeTko { get; set; }
    }
}
